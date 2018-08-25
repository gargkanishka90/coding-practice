using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DesignPatterns.Builder
{
    public class BuilderClient
    {
        public static void TestBuilderPattern()
        {
            var director = new Director(new CarBuilder());
            director.MakeFinalProduct("suv");
            director.ChangeBuilder(new TruckBuilder());
            director.MakeFinalProduct();
            director.ChangeBuilder(new CarBuilder());
            director.MakeFinalProduct("sedan");
        }
    }
}
