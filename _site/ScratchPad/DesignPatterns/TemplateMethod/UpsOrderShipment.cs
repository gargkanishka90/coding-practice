using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScratchPad.DesignPatterns.TemplateMethod
{
    public class UpsOrderShipment : OrderShipment
    {
        public override void GetShippingLabelFromCarrier()
        {
            // Call UPS Web Service
            Label = $"UPS:[{ShippingAddress}]";
        }
    }
}
