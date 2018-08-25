using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.DesignPatterns.Builder.Products;

namespace ScratchPad.DesignPatterns.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car _car;
        public IVehicle MakeProduct(string type = null)
        {
            _car = new Car();
            _car.Name = "Ford ABC1";
            AddBody();
            AddTires();
            AddInterior();
            PaintBody();
            if (type.ToLower().Equals("suv"))
                AddSeats(6);
            else if (type.ToLower().Equals("sedan"))
                AddSeats(4);
            else
                AddSeats(5);
            return _car;
        }

        public void Reset()
        {
            _car = new Car();
        }

        public void AddBody()
        {
            Console.WriteLine("Adding body to Car.");
        }

        public void AddTires()
        {
            _car.NumTires = 4;
            Console.WriteLine("Adding 4 Tires to Car.");
        }

        public void PaintBody()
        {
            _car.Color = "Black";
            Console.WriteLine("Painting Car as Black.");
        }

        public void AddInterior()
        {
            _car.AirConditioned = true;
            Console.WriteLine("Adding seats inside Car.");
        }

        public void AddSeats(int numSeats)
        {
            _car.NumSeats = numSeats;
            Console.WriteLine($"Added {numSeats} seats");
        }
    }
}
