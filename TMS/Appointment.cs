using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Persons;

namespace TMS
{
    internal class Appointment
    {
        public string Date {  get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }

        public Appointment(string date, Doctor doctor, Patient patient)
        {
            Date = date;
            Doctor = doctor;
            Patient = patient;
        }
    }
}
