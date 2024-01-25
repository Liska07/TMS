using System.Numerics;
using TMS.Persons;
using TMS.Companies;

namespace TMS
{
    class Program
    {
        static void Main(string[] args)
        {
            Dentist dent1 = new Dentist("Д_Иванов", "Иван", Gender.male, 1986, 2020, DocQualification.highest, 21);
            Dentist dent2 = new Dentist("Д_Смирнова", "Ольга", Gender.female, 1980, 2023, DocQualification.first, 11);
            Therapist therap1 = new Therapist("Т_Кузьмина", "Анна", Gender.female, 1981, 2001, DocQualification.first, 16);
            Therapist therap2 = new Therapist("Т_Сидоров", "Захар", Gender.male, 1991, 2022, DocQualification.second, 30);
            Surgeon surg1 = new Surgeon("Х_Петров", "Илья", Gender.male, 1975, 2002, DocQualification.highest, 10);
            Surgeon surg2 = new Surgeon("Х_Акунина", "Ирина", Gender.female, 1985, 2016, DocQualification.second, 17);

            Manager manag = new Manager("М_Капустин", "Руслан", Gender.male, 1982, 2020);

            Patient pat1 = new Patient("П_Баталова", "Александра", Gender.female, 1985, 1585);
            Patient pat2 = new Patient("П_Гомонова", "Юлия", Gender.female, 1980, 9845);
            Patient pat3 = new Patient("П_Желтов", "Александр", Gender.male, 1978, 5478);

            ListDoctors();
            ListEmployees();
            ListAppointments();
            ListPersons();
            ListInterface();
            ServicesFromOtherCompany();

            Console.ReadKey();

            void ListDoctors()
            {
                List<Doctor> doctors = new List<Doctor>() //КОЛЛЕКЦИЯ ДОКТОРОВ
                {
                dent1, dent2, therap1, therap2, surg1, surg2
                };
                Console.WriteLine(new string('-', 10) + "Список докторов и их премий" + new string('-', 10));
                foreach (var doctor in doctors)
                {
                    doctor.ShowSurnameName();
                    Console.WriteLine(" - Премия " + CountBonus(doctor) + " руб.");
                }

                int CountBonus(Doctor doc)
                {
                    int bonus = 0;
                    var currentYear = DateTime.Now.Year;
                    if (currentYear - doc.YearOfStarWork >= 5 && doc.qualification == DocQualification.highest)
                        bonus = 7000;
                    else if (currentYear - doc.YearOfStarWork >= 5 && doc.qualification == DocQualification.first)
                        bonus = 5000;
                    else if (currentYear - doc.YearOfStarWork >= 5 && doc.qualification == DocQualification.second)
                        bonus = 3000;
                    return bonus;
                }
            }

            void ListEmployees()
            {
                List<Employee> employees = new List<Employee>() //КОЛЛЕКЦИЯ СОТРУДНИКОВ
                {
                dent1,  therap2, surg1, manag
                };
                Console.WriteLine("\n" + new string('-', 10) + "Список сотрудников и выполняемой работы" + new string('-', 10));
                foreach (var employee in employees)
                {
                    employee.ShowSurnameName();
                    Console.Write(" - ");
                    employee.Work();
                }
                Console.WriteLine("\n" + new string('-', 10) + "Работники завершают рабочий день" + new string('-', 10));
                foreach (var employee in employees)
                {
                    employee.ShowSurnameName();
                    employee.FinishWorkDay();
                }
            }
            void ListAppointments()
            {
                Console.WriteLine("\n" + new string('-', 10) + "Прием врачей" + new string('-', 10));
                Console.WriteLine("Дата \t\tВрач \t\t Пациент");
                List<Appointment> appointments = new List<Appointment>()
                {
                   new Appointment("01.02.2024", dent2, pat1),
                   new Appointment("01.02.2024", dent1, pat2),
                   new Appointment("02.02.2024", surg1, pat3),
                   new Appointment("03.02.2024", therap1, pat2)
                };
                foreach (var appointment in appointments)
                {
                    Console.WriteLine(appointment.Date + "\t" + appointment.Doctor.Surname + "\t " + appointment.Patient.Surname);
                }
            }

            void ListPersons()
            {
                List<Person> persons = new List<Person>() //КОЛЛЕКЦИЯ ВСЕХ ЛЮДЕЙ
                {
                dent1, dent2, therap1, therap2, surg1, surg2, manag, pat1, pat2, pat3
                };
                Console.WriteLine("\n" + new string('-', 10) + "Список всех женщин для 8 марта" + new string('-', 10));
                foreach (var person in persons)
                {
                    if (person.gender == Gender.female)
                    {
                        person.ShowSurnameName();
                        Console.WriteLine();
                    }
                }
            }

            void ListInterface()
            {
                Company companyClean1 = new Cleaning("Super Clean");
                Company companyDel1 = new Delivery("Wow Delivery");

                List<IMessageble> messages = new List<IMessageble>() //КОЛЛЕКЦИЯ ПО ИНТЕРФЕЙСУ
                {
                    dent1, companyDel1, surg2, dent2, therap1,  surg1,   pat1, manag, pat2, therap2, pat3, companyClean1 
                };
                Console.WriteLine("\n" + new string('-', 10) + "Сообщения для всех участников" + new string('-', 10));
                foreach(var message in messages)
                {
                    message.SendMessage();
                }
            }

            void ServicesFromOtherCompany()
            {
                Console.WriteLine("\n" + new string('-', 10) + "Воспользовались услугами сторонних компаний" + new string('-', 10));
                OrderedService serv1 = new OrderedService("12.12.2023", "Вывоз мусора");
                serv1.OrderService(TypeOfService.Cleaning);

                OrderedService serv2 = new OrderedService("15.01.2024", "Отправка документов");
                serv2.OrderService(TypeOfService.Delivery);

                OrderedService servTest = new OrderedService("15.01.2024", "Отправка документов"); //для тестирования try-catch
                try
                {
                    servTest.OrderService(TypeOfService.Test);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}