using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Persons
{
    internal class Patient : Person
    {
        private int _docNumber;
        public int DocNumber
        {
            get { return _docNumber; }
            set 
            {
                if (value > 0)
                    _docNumber = value;
                else
                    Console.WriteLine("Вы ввели некорректный номер кабинета!");
            }
        }
        public Patient(string surname, string name, Gender gender, int yearOfBirth, int docNumber)
            : base (surname, name, gender, yearOfBirth) 
        { 
            DocNumber = docNumber;
        }

        public override void SendMessage()
        {
            base.SendMessage();
            Console.WriteLine(", приходите к нам лечиться!");
        }
    }
}
