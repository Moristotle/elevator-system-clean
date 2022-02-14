using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;
using Domain.Interfaces;

// Klasse som representerer 
namespace Domain.Entities
{
    public class InsideButton : IButton
    {

        private IElevatorMotion? _elevatorMotion;
        public InsideButton(int value)
        {
            Value = value;
        }

        public bool Pressed { get; set; } = false; // Necessary?

        public int Value { get; } // value is the floor

        public void SendInstruction()
        {
            _elevatorMotion!.Move(Value);
        }

        public int SelectFloor()
        {
            return Value;
        }
    }
}