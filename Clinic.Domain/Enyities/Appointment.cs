using Hospital.Domain.Common;
using Hospital.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Appointment: BaseDeletableEntity
    {
 private Appointment() { }
        public Appointment(Guid patientId, Guid doctorId, DateTime appointmentDate, string note)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            Note = note;
        }

        public Guid PatientId { get; private set; }
        public Guid DoctorId { get; private set; }
       public AppointmentStutus Stutus { get; private set; }= AppointmentStutus.Confirmed;



        public DateTime AppointmentDate { get; private set; }
        public string Note { get; private set; } = string.Empty;
        public Appointment Create(Guid patientId, Guid doctorId,DateTime appointmentDate, string note)=>
            new Appointment(patientId, doctorId, appointmentDate, note);

        public void Update(Guid patientId, Guid doctorId, DateTime appointmentDate, string note, AppointmentStutus stutus)
        {
            PatientId = patientId;
            DoctorId = doctorId;
            AppointmentDate = appointmentDate;
            Stutus = stutus;
            Note = note;
        }
    }
}
