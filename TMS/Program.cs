using System.Numerics;
using System.Collections.Generic;
using TMS.Persons;
using TMS.Companies;

namespace TMS
{
    class Program
    {
        public static event Action Fire;
        static void Main(string[] args)
        {
            Dentist dent1;
            Dentist dent2;
            Therapist therap1;
            Therapist therap2;
            Therapist therap3;
            Surgeon surg1;
            Surgeon surg2;
            Manager manag;
            Patient pat1;
            Patient pat2;
            Patient pat3;
            Company companyClean1;
            Company companyDel1;

            try
            {
                dent1 = new Dentist("Д_Иванов", "Иван", Gender.male, 1986, 2020, DocQualification.highest);
                dent2 = new Dentist("Д_Смирнова", "Ольга", Gender.female, 1980, 2023, DocQualification.first);
                therap1 = new Therapist("Т_Кузьмина", "Анна", Gender.female, 1981, 2001, DocQualification.first);
                therap2 = new Therapist("Т_Сидоров", "Захар", Gender.male, 1991, 2022, DocQualification.second);
                therap3 = new Therapist("Д_Смирнов", "Илья", Gender.male, 1989, 2003, DocQualification.second);
                surg1 = new Surgeon("Х_Петров", "Илья", Gender.male, 1975, 2002, DocQualification.highest);
                surg2 = new Surgeon("Х_Акунина", "Ирина", Gender.female, 1985, 2016, DocQualification.second);
                manag = new Manager("М_Капустин", "Руслан", Gender.male, 1982, 2020);
                pat1 = new Patient("П_Баталова", "Александра", Gender.female, 1985, 1585);
                pat2 = new Patient("П_Гомонова", "Юлия", Gender.female, 1980, 9845);
                pat3 = new Patient("П_Желтов", "Александр", Gender.male, 1978, 5478);
                companyClean1 = new Cleaning("Super Clean");
                companyDel1 = new Delivery("Wow Delivery");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Всё пропало! У нас ошибка: {ex.Message}");
                MyLog.LogException(ex);
                return;
            }

            var doctors = new List<Doctor>()
            {
                dent1, dent2, therap1, therap2, surg1, surg2, therap3
            };

            var employees = new List<Employee>()
            {
                dent1,  therap2, surg1, manag
            };

            var people = new List<Person>()
            {
                dent1, dent2, therap1, therap2, surg1, surg2, manag, pat1, pat2, pat3, therap3
            };

            var appointments = new List<Appointment>()
            {
                   new Appointment("01.02.2024", dent2, pat1),
                   new Appointment("01.02.2024", dent2, pat2),
                   new Appointment("02.02.2024", surg1, pat1),
                   new Appointment("03.02.2024", therap1, pat2),
                   new Appointment("02.02.2024", dent2, pat2),
                   new Appointment("01.02.2024", dent1, pat3),
                   new Appointment("02.02.2024", surg1, pat3),
                   new Appointment("02.02.2024", dent2, pat3)
            };

            var phoneBook = new Dictionary<string, Employee>()
            {
                    {"12345", dent1},
                    {"79268", therap1},
                    {"67890", surg1},
                    {"09876", manag},
                    {"11223", dent2},
                    {"22558", surg2 },
                    {"00115", therap3 }
            };

            var messages = new List<IMessageble>()
            {
                    dent1, companyDel1, surg2, dent2, therap1, surg1, pat1, manag, pat2, therap2, pat3, companyClean1
            };

            CountDoctorsBonus(doctors);
            PrintEmployeesWorks(employees);
            FinishEmployeesWorkDay(employees);
            PrintPeopleCertainGender(people, Gender.female);
            PrintListAppointments(appointments);
            PrintPatientsForDay(appointments, "02.02.2024", "Х_Петров");
            PrintPatientsForDay(appointments, "01.02.2024", "Д_Смирнова");
            FindPhoneOfEmployee(phoneBook, "смир");
            PrintMedToOrder();
            PrintMessagesForAll(messages);
            OrderServiceOtherCompany();
            TurnOnFireAlarm(people);

            Console.ReadKey();

            void CountDoctorsBonus(List<Doctor> doctors)
            {
                Console.WriteLine(new string('-', 10) + "Список докторов и их премий" + new string('-', 10));

                foreach (Doctor doctor in doctors)
                {
                    Console.WriteLine(doctor.ShowFullName() + " - Премия: " + doctor.CountBonus() + " руб.");
                }
            }

            void PrintEmployeesWorks(List<Employee> employees)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Список сотрудников и выполняемой работы" + new string('-', 10));

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.ShowFullName() + " - " + employee.Work());
                }
            }

            void FinishEmployeesWorkDay(List<Employee> employees)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Работники завершают рабочий день" + new string('-', 10));

                foreach (Employee employee in employees)
                {
                    Console.WriteLine(employee.ShowFullName() + employee.FinishWorkDay());
                }
            }

            void PrintPeopleCertainGender(List<Person> people, Gender gender) 
            {
                Console.WriteLine("\n" + new string('-', 10) + "Список всех женщин для 8 марта" + new string('-', 10));

                List<Person> selectedPeople =
                    people
                        .Where(a => a.gender == Gender.female)
                        .OrderBy(a => a.Surname)
                        .ToList();

                foreach (Person person in selectedPeople)
                {
                    Console.WriteLine(person.ShowFullName());
                }
            }

            void PrintListAppointments(List<Appointment> appointments)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Прием врачей" + new string('-', 10));

                List<Appointment> sortedAppointments =
                    appointments
                        .OrderBy(a => a.Date)
                        .ToList();

                Console.WriteLine("Дата \t\tВрач \t\t Пациент");
                foreach (Appointment appointment in sortedAppointments)
                {
                    Console.WriteLine(appointment);
                }
            }

            void PrintPatientsForDay(List<Appointment> appointments, string data, string docSurname)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Список пациентов для врача " + docSurname + " на " + data + new string('-', 10));

                List<Patient> selectedPatients =
                    appointments
                        .Where(a => a.Date == data)
                        .Where(a => a.Doctor.Surname == docSurname)
                        .Select(a => a.Patient)
                        .ToList();

                foreach (Patient patient in selectedPatients)
                {
                    Console.WriteLine(patient.ShowFullName() + " - " + patient.YearOfBirth + "г. - Полис: " + patient.DocNumber);
                }
            }

            void PrintMessagesForAll(List<IMessageble> messages)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Сообщения для всех участников" + new string('-', 10));

                foreach (IMessageble message in messages)
                {
                    Console.WriteLine(message.SendMessage());
                }
            }

            void OrderServiceOtherCompany()
            {
                Console.WriteLine("\n" + new string('-', 10) + "Воспользовались услугами сторонних компаний" + new string('-', 10));

                var serv1 = new OrderedService("12.12.2023", "Вывоз мусора");
                TryOrderService(serv1, TypeOfService.Cleaning, "\"Новая клининговая компания\"");

                var serv2 = new OrderedService("15.01.2024", "Отправка документов");
                TryOrderService(serv2, TypeOfService.Delivery, "\"Курьерская компания\"");

                var servTest = new OrderedService("15.01.2024", "ТЕСТ"); //Для тестирования try-catch.
                TryOrderService(servTest, TypeOfService.Test, "\"Тестовая компания\"");
            }

            void TryOrderService(OrderedService serv, TypeOfService typeOfService, string nameOfCompany)
            {
                try
                {
                    Console.WriteLine(serv.OrderService(typeOfService, nameOfCompany));
                }
                catch (NotImplementedException ex)
                {
                    Console.WriteLine(ex.Message);
                    MyLog.LogException(ex);
                }
            }

            void FindPhoneOfEmployee(Dictionary<string, Employee> phoneBook, string surname)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Поиск по телефонному справочнику сотрудников" + new string('-', 10));

                bool isFound = false;
                foreach (KeyValuePair<string, Employee> phone in phoneBook)
                {
                    if (phone.Value.Surname.ToLower().Contains(surname.ToLower()))
                    {
                        Console.WriteLine($"Тел: {phone.Key} - {phone.Value.Surname} {phone.Value.Name}");
                        isFound = true;
                    }
                }
                if (!isFound)
                    Console.WriteLine($"Сотрудника с фамилией {surname} в справочнике нет");
            }

            void PrintMedToOrder()
            {
                Console.WriteLine("\n" + new string('-', 10) + "Надо срочно сделать вот такой заказ на пилюльки" + new string('-', 10));

                Dictionary<string, int> MedForOrder = new MedicationsBalance().GetMedToOrder();
                foreach (KeyValuePair<string, int> item in MedForOrder)
                {
                    Console.WriteLine(item.Key + " " + item.Value + " шт.");
                }
            }

            void TurnOnFireAlarm(List<Person> people)
            {
                Console.WriteLine("\n" + new string('-', 10) + "Оповещение о пожаре" + new string('-', 10));

                foreach (Person person in people)
                {
                    Fire += person.OnFire;
                }
                Fire -= dent2.OnFire;
                Fire.Invoke();
            }
        }
    }
}