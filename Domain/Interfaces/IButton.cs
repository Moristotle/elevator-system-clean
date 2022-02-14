using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Interfaces
{
    public interface IButton
    {
        public bool Pressed { get; set; }

        public void SendInstruction();
    }
}