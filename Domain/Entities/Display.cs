using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Might be an abstract class that is implemented different places
namespace Domain.Entities
{
    public class Display
    {
        public int FloorNumber { get; set; }

        public int Direction { get; set; }

        public void ShowDisplay() { }
    }
}