using System;
using System.Collections.Generic;
using System.Linq;

namespace Shared
{
    public class Clusterizer : IClusterizer
    {
        public IList<Parameters> CalculateParameters(IEnumerable<LabelGroup> objects, ref int[,] labels)
        {
            int[,] ints = labels;
            return objects.Select(group => CalculateParameter(group, ints)).ToList();
        }

        public IList<Cluster> Clusterize(IList<Parameters> parameters, int k)
        {
            List<Cluster> result;
            var indexes = GetRandomIndexes(k, parameters.Count, null);
            var representativeObjects = indexes.Select(index => parameters[index]).ToList();
            var medoids = representativeObjects;
            bool flag;

            do
            {
                var distances = SearchDistances(parameters, medoids);
                result = SeparateToClusters(parameters, distances, medoids);
                medoids = FindMedoids(result);
                indexes = GetRandomIndexes(k, parameters.Count, indexes);
                flag = Compare(representativeObjects, medoids);
                for (var i = 0; i < representativeObjects.Count; i++)
                {
                    representativeObjects[i] = medoids[i];
                }

            } while (!flag);

            return result;
        }

        private static bool Compare(ICollection<Parameters> representativeObjects, IEnumerable<Parameters> medoids)
        {
            return medoids.All(representativeObjects.Contains);
        }

        private static IList<int> GetRandomIndexes(int k, int count, ICollection<int> previousIndexes)
        {
            var random = new Random();
            var indexes = new int[k];
            for (int i = 0; i < k; i++)
            {
                var index = random.Next(count);
                if (indexes.Contains(index))
                {
                    i--; continue;
                }
                if (previousIndexes != null)
                {
                    if (previousIndexes.Contains(index))
                    {
                        i--; continue;
                    }
                }
                indexes[i] = index;
            }
            return indexes;
        }

        /*
        private static bool IsChanched(int[] lastMask, int[] clustersMask)
        {
            if (lastMask.Length == 0 && clustersMask.Length == 0)
            {
                return true;
            }
            return lastMask.Where((t, i) => t != clustersMask[i]).Any();
        }

        private static int[] CalculateClustersMask(IEnumerable<Cluster> result)
        {
            return result.Select(x => x.Objects.Sum(item => item.Pixels.Count)).ToArray();
        }*/

        private static List<Parameters> FindMedoids(IEnumerable<Cluster> result)
        {
            return result.Select(item => FindMedoid(item.Objects)).ToList();
        }

        private static Parameters FindMedoid(IList<Parameters> parameters)
        {
            Parameters medoid = null;
            var medoidDistancesSum = double.MaxValue;

            foreach (var parameter in parameters)
            {
                var distancesSum = parameters.Sum(parameterToCompare => SearchDistance(parameterToCompare, parameter));

                if (distancesSum > medoidDistancesSum)
                {
                    continue;
                }

                medoid = parameter;
                medoidDistancesSum = distancesSum;
            }

            return medoid;
        }

        private static List<Cluster> SeparateToClusters(IEnumerable<Parameters> parameters, Dictionary<Parameters, double[]> distances, IEnumerable<Parameters> medoids)
        {
            var result = medoids.Select(medoid => new Cluster {Medoid = medoid, Objects = new List<Parameters>()}).ToList();
            foreach (var parameter in parameters)
            {
                var index = FindMinIndex(distances[parameter]);
                result[index].Objects.Add(parameter);
            }


            return result;
        }

        private static int FindMinIndex(IList<double> distances)
        {
            var index = 0;
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] < distances[index])
                {
                    index = i;
                }
            }

            return index;
        }

        private static Dictionary<Parameters, double[]> SearchDistances(IEnumerable<Parameters> parameters, IList<Parameters> medoids)
        {
            var result = new Dictionary<Parameters, double[]>();
            foreach (var parameter in parameters)
            {
                var distances = new double[medoids.Count];
                for (var i = 0; i < medoids.Count; i++ )
                {
                    distances[i] = SearchDistance(parameter, medoids[i]);
                }
                result.Add(parameter, distances);
            }

            return result;
        }

        private static double SearchDistance(Parameters parameter, Parameters medoid)
        {
            var avgSquare = (double)(parameter.Square - medoid.Square);//medoid.Square;
            var avgElongation = (parameter.Elongation - medoid.Elongation);//medoid.Elongation;
            var avgPerimeter = (double)(parameter.Perimeter - medoid.Perimeter);//medoid.Perimeter;
            var avgDensity = (parameter.Density - medoid.Density);//medoid.Density;

            return Math.Sqrt(Math.Pow(avgSquare, 2) + Math.Pow(avgElongation, 2) +  Math.Pow(avgPerimeter, 2) + Math.Pow(avgDensity, 2));
        }

        private static Parameters CalculateParameter(LabelGroup group, int[,] labels)
        {
            var result = new Parameters
                {
                    Square = group.Pixels.Count
                };

            int x = 0, y = 0, perimeter = 0;
            foreach (var item in group.Pixels)
            {
                if (IsBorderPixel(item.X, item.Y, ref labels))
                {
                    perimeter++;
                }
                x += item.X;
                y += item.Y;
            }
            result.SchtynhMasses = new Coords(x/result.Square, y/result.Square);
            result.Perimeter = perimeter;
            result.Density = (double)result.Perimeter*result.Perimeter / result.Square;

            var m20 = DiscretMoment(result.SchtynhMasses.X, result.SchtynhMasses.Y, group.Pixels, 2, 0);
            var m02 = DiscretMoment(result.SchtynhMasses.X, result.SchtynhMasses.Y, group.Pixels, 0, 2);
            var m11 = DiscretMoment(result.SchtynhMasses.X, result.SchtynhMasses.Y, group.Pixels, 1, 1);

            var sqrt = Math.Sqrt(Math.Pow(m20 - m02, 2) + 4*m11*m11);
            result.Elongation = (m20 + m02 + sqrt)/(m20 + m02 - sqrt);
            result.Theta = Math.Atan(2*m11/(m20 - m02)) / 2;
            result.Pixels = group.Pixels;

            return result;
        }

        private static bool IsBorderPixel(int x, int y, ref int[,] labels)
        {
            try
            {
                return labels[x + 1, y] == 0 || labels[x, y + 1] == 0 || labels[x - 1, y] == 0 || labels[x, y - 1] == 0;
            }
            catch
            {
                return false;
            }
        }

        private static double DiscretMoment(int x, int y, IEnumerable<Coords> pixels, int i, int j)
        {
            return pixels.Sum(pixel => Math.Pow((pixel.X - x), i)*Math.Pow((pixel.Y - y), j));
        }
    }
}
