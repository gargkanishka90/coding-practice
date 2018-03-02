using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DesignPatterns.TemplateMethod
{
    public class TemplateMethodPattern
    {
        public static void Run()
        {
            OrderShipment service = new UpsOrderShipment();
            service.ShippingAddress = "New York";
            service.Ship(Console.Out);

            OrderShipment serviceTwo = new FedExOrderShipment();
            serviceTwo.ShippingAddress = "Los Angeles";
            serviceTwo.Ship(Console.Out);

            Console.ReadKey();
        }
    }
}
