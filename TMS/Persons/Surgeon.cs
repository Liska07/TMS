

namespace TMS.Persons
{
    public class Surgeon : Doctor
    {
        public Surgeon(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification)
        {

        }
        public override string Work()
        {
            return "Ампутация чего только пожелаете";
        }
        public override string FinishWorkDay()
        {
            return ", прибери, что ампутировал и свободен!";
        }
    }
}
