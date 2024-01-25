using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Companies
{
    internal class Cleaning : Company
    {
        public Cleaning(string name) : base(name)
        {
        }

        public override void Work()
        {
            Console.WriteLine(Name + " навела чистоту и порядок!");
        }
    }
}
