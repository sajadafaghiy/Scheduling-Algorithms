using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingAlgorithms.Extensions
{
    public static class Extensions
    {
        public static IList<T> Clone<T>(this IList<T> list) where T : ICloneable
        {
            return list.Select(x => (T)x.Clone()).ToList();
        }
    }
}
