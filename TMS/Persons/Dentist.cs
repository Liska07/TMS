
namespace TMS.Persons
{
    public class Dentist : Doctor
    {
        public Dentist(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification)
        {
        }
        public override string Work()
        {
            return "Удаление зубов";
        }
        public override string FinishWorkDay()
        {
            return", cобери зубы и иди домой!";
        }
        public override string  SendMessage()
        {
            return ShowFullName() + ", зуб сам себя не вырвет! Вперёд работать!";
        }
    }
}
