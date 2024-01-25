using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Persons
{
    internal class Manager : Employee
    {
        public Manager(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork)
                : base(surname, name, gender, yearOfBirth, yearOfStartWork)
        {
           
        }
        public override void Work()
        {
            Console.WriteLine("Увольнение по поводу и без");
        }
        public override void SendMessage()
        {
            base.SendMessage();
            Console.WriteLine(", пора кого-нибудь уволить!"); ;
        }
    }
}
