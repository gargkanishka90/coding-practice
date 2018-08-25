using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DesignPatterns.Builder.Products
{
    public class Truck : IVehicle
    {
        public int NumTires { get; set; }
        public string Color { get; set; }
        public bool AirConditioned { get; set; }
        public string Name { get; set; }
        public int NumSeats { get; set; }
    }
}
