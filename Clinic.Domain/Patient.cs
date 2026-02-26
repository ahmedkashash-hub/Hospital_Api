using Hospital.Domain.Enyities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Hospital.Domain
{

   
    public class Patient:Person { 
        private Patient() { }
        public Patient(Guid personId, Guid doctorId, int bookingNuber, string note)
        {
            PersonId = personId;
            DoctorId = doctorId;
            BookingNuber = bookingNuber;
            Note = note;
        }
        public Guid PersonId { get;private set; }
        public Guid DoctorId { get;private set; }
        public Guid DiseaseId { get; private set; }
        public int BookingNuber { get;private set; }
        public string Note { get; private set; }= string.Empty;

        public static Patient create (Guid personId, Guid doctorId, int bookingNuber, string note)=>new Patient( personId, doctorId, bookingNuber, note);



        public void Update(Guid personId, Guid doctorId, int bookingNuber, string note)
        {

            PersonId = personId;
            DoctorId = doctorId;
            BookingNuber = bookingNuber;
            Note = note;
            
        }



    }
}
