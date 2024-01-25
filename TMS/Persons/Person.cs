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
                if (value != "")
                    _surname = value;
                else
                    Console.WriteLine("Вы указали некорректную фамилию!");
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
                if (value != "")
                    _name = value;
                else
                    Console.WriteLine("Вы указали некорректное имя!");
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
                    Console.WriteLine("Вы указали некорректный год рождения!");
            }
        }

        public Person(string surname, string name, Gender gender, int yearOfBirth)
        {
            Surname = surname;
            Name = name;
            this.gender = gender;
            YearOfBirth = yearOfBirth;
        }
        public void ShowSurnameName()
        {
            Console.Write(Surname + " " + Name);
        }
        public virtual void SendMessage()
        {
            ShowSurnameName();
        }
    }
}
