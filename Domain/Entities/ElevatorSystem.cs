/*

Implemented in Application layer instead of here.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;

namespace Domain.Entities
{
    public class ElevatorSystem : IElevatorSystem, IEmergencySystem
    {
        public List<Floor> Floors { get; set; }
        public Elevator Car { get; set; }

        public ElevatorSystem(int numberOfFloors, IEmergencySystem emergencySystem)
        {
            Car = new Elevator(Enumerable.Range(1, numberOfFloors).Select(floorNumber => new InsideButton(floorNumber)).ToList());
            Floors = Enumerable.Range(1, numberOfFloors).Select(floorNumber => new Floor(floorNumber, emergencySystem)).ToList();
        }

        public void ShowEmergencyLights(int? floor)
        {
            Console.WriteLine("Emergency at floor {0}..!", floor);
        }

        public void Update(int floorNumber, int destinationFloor, int selectedFloors)
        {
            Car.CurrentFloor = floorNumber;
            Car.selectedFloors = 
            Car.Move(destinationFloor);
        }

        public void step()
        {
            throw new NotImplementedException();
        }
    }
}

*/