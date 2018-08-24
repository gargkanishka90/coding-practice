using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.DesignPatterns.Builder.Products;

namespace ScratchPad.DesignPatterns.Builder
{
    public interface IBuilder
    {
        IVehicle MakeProduct();
        void Reset();
        void AddBody();
        void AddTires();
        void PaintBody();
        void AddInterior();

    }
}
