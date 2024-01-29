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
        private string _date;
        private Doctor _doctor;
        private Patient _patient;

        public Appointment(string date, Doctor doctor, Patient patient)
        {
            _date = date;
            _doctor = doctor;
            _patient = patient;
        }
        public override string ToString()
        {
            return _date + "\t" + _doctor.Surname + "\t " + _patient.Surname;
        }
    }
}
