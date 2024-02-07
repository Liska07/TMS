
namespace TMS.Persons
{
    public class Therapist : Doctor
    {
        public Therapist(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification)
        {

        }
        public override string Work()
        {
            return "Измерение температуры";
        }
        public override string SendMessage()
        {
            
            return ShowFullName() + ", хватай градусник и мерь температуру!";
        }
    }
}
