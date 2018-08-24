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
        public IVehicle MakeProduct()
        {
            _car = new Car();
            AddBody();
            AddTires();
            AddInterior();
            PaintBody();
            return _car;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void AddBody()
        {
            Console.WriteLine("Adding body to Car.");
        }

        public void AddTires()
        {
            Console.WriteLine("Adding 4 Tires to Car.");
        }

        public void PaintBody()
        {
            Console.WriteLine("Painting Car as Black.");
        }

        public void AddInterior()
        {
            Console.WriteLine("Adding seats inside Car.");
        }
    }
}
