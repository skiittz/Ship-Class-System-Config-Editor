using System.Collections.Generic;

namespace ShipConfigurator_Definitions
{
    public class Zones
    {
        public List<long> AllowedClassesById { get; set; }
        public int Id { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public double Radius { get; set; }

        public Zones()
        {
            AllowedClassesById = new List<long>();
        }
    }
}
