using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Application
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

        public void MoveElevator(int floorNumber, int destinationFloor, int selectedFloors)
        {
            Car.CurrentFloor = floorNumber;
            Car.SelectFloor(selectedFloors);
            Car.Move(destinationFloor);
        }

    }
}