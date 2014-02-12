using System.Collections.Generic;

namespace Shared
{
    public interface IClusterizer
    {
        IList<Parameters> CalculateParameters(IEnumerable<LabelGroup> objects, ref int[,] labels);
        IList<Cluster> Clusterize(IList<Parameters> parameters, int parse);
    }
}
