using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //class Customer has inherited all attributes, methods, setter & getter
    class Customer:Person
    {
        private string _ShippingAddress;

        public string shippingAddress {
            get { return this._ShippingAddress; }
            set { this._ShippingAddress = value; }
        }
        
        private string _ShipmentAddress()
        {
            _ShippingAddress.Trim().Replace(",","-").Replace(";","\n");
            return _ShippingAddress;
        }
        public void ShipmentAddress()
        {
            Console.WriteLine("Shippment Address: {0}", _ShippingAddress);
        }
    }
}
