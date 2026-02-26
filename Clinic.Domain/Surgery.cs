using Hospital.Domain.Common;
using Hospital.Domain.Enyities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain
{
    public class Surgery:BaseEntity
    {
        private Surgery() { }
        public Surgery(Guid doctorId, Guid patientId, DateTime date, string description, decimal cost,Guid Room,List<Doctor> doctors,List<Nurse> nurses)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            Date = date;
            Description = description;
            Cost = cost;
            this.Room = Room;
            this.doctors = doctors;
            this.nurses = nurses;
        }

        public Guid DoctorId { get; private set; }
        public Guid PatientId { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; } = string.Empty;
        public decimal Cost { get; private set; }
        public List<Doctor>doctors { get; private set; } = new List<Doctor>();
        public List<Nurse>nurses { get; private set; } = new List<Nurse>();

        public Guid Room { get; private set; }
        public Surgery Create(Guid doctorId, Guid patientId, DateTime date, string description, decimal cost ,Guid Room,List<Doctor> doctors,List<Nurse> nurses)=>new Surgery(doctorId, patientId, date, description, cost, Room, doctors, nurses);

        public void Update(Guid doctorId, Guid patientId, DateTime date, string description, decimal cost,Guid Room,List<Doctor>doctors,List<Nurse>nurses)
        {
            DoctorId = doctorId;
            PatientId = patientId;
            Date = date;
            Description = description;
            Cost = cost;
            this.Room = Room;
           this. doctors = doctors;
           this. nurses = nurses;
        }

    }
}
