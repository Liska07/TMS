
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
        private DocQualification qualification;
        public Doctor(string surname, string name, Gender gender, int yearOfBirth, int yearOfStartWork, DocQualification qualification)
            : base(surname, name, gender, yearOfBirth, yearOfStartWork)
        {
            this.qualification = qualification;
        }

        public override string FinishWorkDay()
        {
            return ", завершай рабочий день как простой доктор";
        }

        public override string SendMessage()
        {
            return base.SendMessage() + ", вперед и с песней! Пациенты ждут!";
        }

        public int CountBonus()
        {
            int bonus = 0;

            if (CountWorkExperience() >= 5 && qualification == DocQualification.highest)
                bonus = 7000;
            else if (CountWorkExperience() >= 5 && qualification == DocQualification.first)
                bonus = 5000;
            else if (CountWorkExperience() >= 5 && qualification == DocQualification.second)
                bonus = 3000;
            return bonus;
        }

        private int CountWorkExperience()
        {
            int workExperience = DateTime.Now.Year - YearStartWork;

            return workExperience;
        }
        public override void OnFire()
        {
            Console.WriteLine("Док " + ShowFullName() + ", ты давал клятву! Не дай сгореть пациентам!");
        }
    }
}
