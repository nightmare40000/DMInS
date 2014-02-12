using System.Collections.Generic;

namespace Shared
{
    public class Parameters
    {
        public int Square { get; set; }
        public int Perimeter { get; set; }
        public Coords SchtynhMasses { get; set; }
        public double Density { get; set; }
        public double Elongation { get; set; }
        public double Theta { get; set; }
        public List<Coords> Pixels { get; set; }

        public override string ToString()
        {
            return string.Format("({0}), ({1})",Square,Perimeter);
        }
    }
}
