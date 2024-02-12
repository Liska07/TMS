using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Persons;

namespace TMS
{
    public class Appointment
    {
        public string Date { get; private set; }
        public Doctor Doctor { get; private set; }
        public Patient Patient { get; private set; }

        public Appointment(string date, Doctor doctor, Patient patient)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
        }
        public override string ToString()
        {
            return Date + "\t" + Doctor.Surname + "\t " + Patient.Surname;
        }
    }
}
