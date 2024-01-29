using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Persons
{
    public abstract class Employee : Person
    {
        private int _yearOfStartWork;
        public int YearOfStarWork
        {
            get
            {
                return _yearOfStartWork;
            }
            set
            {
                if (value >= 2000)
                    _yearOfStartWork = value;
                else
                    Console.WriteLine("Вы указали некорректный год начала работы сотрудника в клинике!");
            }
        }
        public Employee(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork)
                : base(surname, name, gender, yearOfBirth)
        {
            YearOfStarWork = yearOfStartWork;
        }

        public abstract void Work();

        public virtual void FinishWorkDay()
        {
            Console.WriteLine(", завершай рабочий день как обычный сотрудник");
        }
    }
}
