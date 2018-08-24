using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.DesignPatterns.Builder.Products;

namespace ScratchPad.DesignPatterns.Builder
{
    public class TruckBuilder : IBuilder
    {
        private Truck _truck;
        public IVehicle MakeProduct()
        {
            _truck = new Truck();
            AddBody();
            AddTires();
            AddInterior();
            PaintBody();
            return _truck;
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public void AddBody()
        {
            Console.WriteLine("Adding body to Truck.");
        }

        public void AddTires()
        {
            Console.WriteLine("Adding 12 Tires to Truck.");
        }

        public void PaintBody()
        {
            Console.WriteLine("Painting Truck as Grey.");
        }

        public void AddInterior()
        {
            Console.WriteLine("Adding seats inside Truck.");
        }
    }
}
