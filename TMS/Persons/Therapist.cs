
namespace TMS.Persons
{
    public class Therapist : Doctor
    {
        public Therapist(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification, int officeNumber)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification, officeNumber)
        {

        }
        public override void Work()
        {
            Console.WriteLine("Измерение температуры");
        }
        public override void SendMessage()
        {
            ShowSurnameName();
            Console.WriteLine(", хватай градусник и мерь температуру!");
        }
    }
}
