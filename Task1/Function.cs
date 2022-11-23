using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    struct Function
    {
       
        double k;
        double b;

        public Function(double k, double b)
        {
            this.k = k;
            this.b = b;
        }
        public string Root()
        {
            if (k == 0 && b == 0)
            {
                return "любое число";
            }
            else if (b == 0)
            {
                return "0";
            }
            else
            {
                return $"{-b / k}";
            }
        }
    }
}
