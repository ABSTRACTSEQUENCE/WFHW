using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2
{
    public class Prod
    {
        public string name { get; set; }
        public double price { get; set; }

        public Prod()
        {
            name = "";
            price = 0;
        }
        public Prod(string n, double p)
        {
            name = n;
            price = p;
        }

        public override string ToString()
        {
            return name + "\tЦена:\t" + price.ToString();
        }

    }
}
