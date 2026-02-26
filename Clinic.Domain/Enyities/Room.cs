using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Room:BaseEntity
    {

      
        public Guid PatientId { get; private set; }
        public Guid Departement { get; private set; }
        public string RoomNumber { get; private set; } = string.Empty;

        public int Bednumber{ get; private set; }
        public Room Create(Guid patientId, Guid departement, string roomNumber, int bednumber)
        {
            return new Room
            {
                PatientId = patientId,
                Departement = departement,
                RoomNumber = roomNumber,
                Bednumber = bednumber
            };
        }
        public void Update(Guid patientId, Guid departement, string roomNumber, int bednumber)
        {
            PatientId = patientId;
            Departement = departement;
            RoomNumber = roomNumber;
            Bednumber = bednumber;
        }

    }
}
