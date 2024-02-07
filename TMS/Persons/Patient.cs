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
                    throw new ArgumentException("Вы ввели некорректный номер документа!");
            }
        }
        public Patient(string surname, string name, Gender gender, int yearOfBirth, int docNumber)
            : base (surname, name, gender, yearOfBirth) 
        { 
            DocNumber = docNumber;
        }

        public override string SendMessage()
        {
            return base.SendMessage() + ", приходите к нам лечиться!";
        }
        public override void OnFire()
        {
            Console.WriteLine(ShowFullName() + ", спасай свою шкуру! Горим!");
        }
    }
}
