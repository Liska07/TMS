using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TMS.Companies 
{
    public abstract class Company : IMessageble
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("Вы указали некорректное название компании!");
                else
                    _name = value;
            }
        }
        public Company(string name)
        {
            Name = name;
        }
        public abstract string Work();

        public string SendMessage()
        {
            return Name + "! С вами классно сотрудничать, но дайте нам скидку!";
        }
    }
}
