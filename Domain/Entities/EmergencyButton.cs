using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class EmergencyButton : IButton
    {

        private IEmergencySystem _emergencySystem;

        public EmergencyButton(IEmergencySystem emergencySystem, int value)
        {
            _emergencySystem = emergencySystem;
            Value = value;
        }

        public bool Pressed { get; set; } = false; // necessary?

        public int Value { get; }

        public void SendInstruction()
        {

            _emergencySystem.ShowEmergencyLights(Value);

        }

    }
}