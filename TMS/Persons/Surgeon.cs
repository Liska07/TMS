

namespace TMS.Persons
{
    public class Surgeon : Doctor
    {
        public Surgeon(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification, int officeNumber)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork, qualification, officeNumber)
        {

        }
        public override void Work()
        {
            Console.WriteLine("Ампутация чего только пожелаете");
        }
        public override void FinishWorkDay()
        {
            Console.WriteLine(", прибери, что ампутировал и свободен!");
        }
    }
}
