
namespace TMS.Persons
{
    public enum DocQualification
    {
        second,
        first,
        highest
    }
    public abstract class Doctor : Employee
    {
        public DocQualification qualification;

        private int _officeNumber;
        public int OfficeNumber
        {
            get
            {
                return _officeNumber;
            }
            set
            {
                if (value > 0)
                    _officeNumber = value;
                else
                    Console.WriteLine("Вы ввели некорректный номер кабинета!");

            }
        }

        public Doctor(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification, int officeNumber)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork)
        {
            this.qualification = qualification;
            OfficeNumber = officeNumber;
        }

        public override void FinishWorkDay()
        {
            Console.WriteLine(", завершай рабочий день как простой доктор");
        }
        public override void SendMessage()
        {
            base.SendMessage();
            Console.WriteLine(", вперед и с песней! Пациенты ждут!");
        }
    }
}
