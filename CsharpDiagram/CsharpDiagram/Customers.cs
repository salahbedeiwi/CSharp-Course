using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CsharpDiagram
{
    public interface Customers
    {
        string City { get; set; }
        string Address { get; set; }
        Story Story { get; set; }
    }
}