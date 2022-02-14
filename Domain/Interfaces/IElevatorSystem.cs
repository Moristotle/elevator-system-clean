using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IElevatorSystem
    {
        void MoveElevator(int floorNumber, int destinationFloor, int selectedFloor);
        // void step(); // Use to calculate distance between floors. - Increment step for every passing between floors & Calculate absolute distance based on currentFloor += floors.length
    }
}