using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
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
        public override string Work()
        {
            return "Увольнение по поводу и без";
        }
        public override string SendMessage()
        {
            return base.SendMessage() + ", пора кого-нибудь уволить!"; ;
        }
        public override void OnFire()
        {
            Console.WriteLine("Менеджер, горим! " + ShowFullName() +  ", хватай бабло, а то сгорит!");
        }
    }
}
