using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class OutsideButton : IButton
    {
        private IElevatorMotion _elevatorMotion;
        public OutsideButton(int value, IElevatorMotion elevatorMotion)
        {
            Value = value;
            _elevatorMotion = elevatorMotion;
        }

        public bool Pressed { get; set; } = false;
        public int Value { get; }

        public void SendInstruction()
        {
            _elevatorMotion.Move(Value);
        }
    }
}