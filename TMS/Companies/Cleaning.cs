using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Companies
{
    public class Cleaning : Company
    {
        public Cleaning(string name) : base(name)
        {
        }

        public override string Work()
        {
            return Name + " навела чистоту и порядок!";
        }
    }
}
