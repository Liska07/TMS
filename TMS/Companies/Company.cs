using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Companies 
{
    public abstract class Company : IMessageble
    {
        public string Name { get; set; }

        public Company(string name)
        {
            Name = name;
        }
        public abstract void Work();

        public void SendMessage()
        {
            Console.WriteLine(Name + "! С вами классно сотрудничать, но дайте нам скидку!");
        }
    }
}
