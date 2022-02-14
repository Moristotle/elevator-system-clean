using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IElevatorMotion
    {
        void Move(int floor);
        void Stop();

        void SelectFloor(int selectedFloor);
    }
}