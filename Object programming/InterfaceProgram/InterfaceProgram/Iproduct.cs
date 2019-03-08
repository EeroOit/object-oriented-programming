using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTask
{
    interface IProduct
    {
        Object GetProduct(string name);
        double CalculateTotal();
    }
}