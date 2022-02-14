using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Monitoring
    {
        public bool Break { get; set; }

        public bool Weight { get; set; }

        public bool ElectricityLevel { get; set; }

        public void CheckMonitor() { }
    }
}