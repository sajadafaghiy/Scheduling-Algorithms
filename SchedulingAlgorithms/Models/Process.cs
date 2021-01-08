using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulingAlgorithms.Models
{
    public class Process : ICloneable
    {
        public string Name { get; set; }
        public int Duration { get; set; }
        public int ArrivalTime { get; set; }

        public int TimeLeft { get; set; }
        public int? StartTime { get; set; }
        public int? EndTime { get; set; }
        public double? Priority { get; set; }

        public Process(string name, int arrivalTime, int duration)
        {
            Name = name;
            ArrivalTime = arrivalTime;
            Duration = duration;
            TimeLeft = duration;
        }

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
