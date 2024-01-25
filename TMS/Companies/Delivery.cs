using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Companies
{
    internal class Delivery : Company
    {
        public Delivery(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine(Name + " доставила все в лучшем виде!");
        }
    }
}
