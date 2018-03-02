using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DesignPatterns.TemplateMethod
{
    public class FedExOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call FedEx Web Service
            Label = $"FedEx:[{ShippingAddress}]";
        }
    }
}
