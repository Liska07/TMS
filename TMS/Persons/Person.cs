using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Persons
{
    public enum Gender
    {
        male,
        female
    }
    public abstract class Person : IMessageble
    {
        private string _surname;
        public string Surname 
        {
            get
            {
                return _surname;
            }
            set
            {
                if (value == "" || value == null)
                    throw new ArgumentException("Вы указали некорректную фамилию!");
                else
                    _surname = value;
            }
        }
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
                    throw new ArgumentException("Вы указали некорректное имя!");
                else
                    _name = value;
            } 
        }
        public Gender gender;

        private int _yearOfBirth;
        public int YearOfBirth 
        {
            get
            {
                return _yearOfBirth;
            }
            set
            {
                if (value > 1900)
                    _yearOfBirth = value;
                else
                    throw new ArgumentException("Вы указали некорректный год рождения!");
            }
        }

        public Person(string surname, string name, Gender gender, int yearOfBirth)
        {
            Surname = surname;
            Name = name;
            this.gender = gender;
            YearOfBirth = yearOfBirth;
        }
        public string ShowFullName()
        {
            return Surname + " " + Name;
        }
        public virtual string SendMessage()
        {
            return ShowFullName();
        }

        public abstract void OnFire();
       
    }
}
