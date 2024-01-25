
namespace TMS.Persons
{
    public class Dentist : Doctor
    {
        public Dentist(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification, int officeNumber)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification, officeNumber)
        {
           
        }
        public override void Work()
        {
            Console.WriteLine("Удаление зубов");
        }
        public override void FinishWorkDay()
        {
            Console.WriteLine(", cобери зубы и иди домой!");
        }
        public override void SendMessage()
        {
            ShowSurnameName();
            Console.WriteLine(", зуб сам себя не вырвет! Вперёд работать!");
        }
    }
}
