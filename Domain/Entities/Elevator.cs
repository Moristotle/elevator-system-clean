using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Interfaces;
using Domain.Enums;

namespace Domain.Entities
{
    public class Elevator : IElevatorMotion
    {
        public Elevator(List<InsideButton> buttons)
        {
            Buttons = buttons;

        }

        public Direction ElevatorDirection { get; set; } = Direction.Idle;

        public List<InsideButton> Buttons { get; }
        public bool IsMoving { get; set; } // necessary?
        public int CurrentFloor { get; set; } = 1;
        public int DestinationFloor { get; set; }

        public IQueryable<IEnumerable<int>>? selectedFloors { get; set; }

        public void Move(int floor)
        {

            if (CurrentFloor < floor)
            {
                ElevatorDirection = Direction.Down;
                DestinationFloor = floor;
                IsMoving = true;
            }
            else if (CurrentFloor == floor)
            {
                IsMoving = false;
                Console.WriteLine("Same floor champ.. Same floor");
                return;
            }
            else
            {
                ElevatorDirection = Direction.Up;
                DestinationFloor = floor;
                IsMoving = true;
            }

            Console.WriteLine("Elevator has been moved to floor {0} in direction: {1}", floor, ElevatorDirection);
        }

        public void SelectFloor(int selectedFloor)
        {
            selectedFloors!.Append(Buttons.Select(button =>
            {
                if (button.Value == selectedFloor)
                {
                    return button.Value;
                }
                return button.Value;
            }));
            Console.WriteLine("Selected floor {0}", selectedFloor);

        }

        public void Stop()
        {
            IsMoving = false;
            Console.WriteLine("Elevator has been stopped at floor {0}", CurrentFloor);
        }
    }
}