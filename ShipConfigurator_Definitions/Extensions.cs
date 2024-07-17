using System;
using System.Collections.Generic;
using System.Linq;

namespace ShipConfigurator_Definitions
{
    public static class ListExtensions
    {
        public static List<T> Clone<T>(this List<T> source) where T : ICloneable
        {
            return source.Select(x => (T)x.Clone()).ToList();
        }
    }
}
