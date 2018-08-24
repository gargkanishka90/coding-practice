using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScratchPad.DesignPatterns.Builder;
using ScratchPad.DesignPatterns.Builder.Products;

namespace ScratchPad.DesignPatterns
{
    public class Director
    {
        private IBuilder _builder;
        public Director(IBuilder builder)
        {
            _builder = builder;
        }

        public void ChangeBuilder(IBuilder newBuilder)
        {
            _builder = newBuilder;
        }

        public IVehicle MakeFinalProduct()
        {
            return _builder.MakeProduct();
        }
    }
}
