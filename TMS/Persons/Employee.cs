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
        public int YearStartWork
        {
            get
            {
                return _yearOfStartWork;
            }
            set
            {
                int yearOfStartClinic = 2000;
                if (value >= yearOfStartClinic)
                    _yearOfStartWork = value;
                else
                    throw new ArgumentException("Вы указали некорректный год начала работы сотрудника в клинике!");
            }
        }
        public Employee(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork)
                : base(surname, name, gender, yearOfBirth)
        {
            YearStartWork = yearOfStartWork;
        }

        public abstract string Work();

        public virtual string FinishWorkDay()
        {
            return ", завершай рабочий день как обычный сотрудник";
        }
    }
}
