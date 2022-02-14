using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Common;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class Floor : IEmergencySystem
    {
        private IEmergencySystem _emergencySystem;

        public Floor(int value, IEmergencySystem emergencySystem)
        {
            Value = value;
            _emergencySystem = emergencySystem;
        }


        public int Value { get; set; }

        public OutsideButton? Button { get; set; }

        public void ShowEmergencyLights(int? floor)
        {
            _emergencySystem.ShowEmergencyLights(Value);
        }
    }
}