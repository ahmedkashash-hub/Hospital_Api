using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Department:BaseAuditableEntity
    {
        private Department() { }
        public Department(string name, string description, string location, string phoneNumber, int floor)
        {
            Name = name;
            Description = description;
            Location = location;
            PhoneNumber = phoneNumber;
            Floor = floor;
        }
        public string Name { get;private set; }= string.Empty;
        public string Description { get; private set; } = string.Empty;
        public string Location { get; private set; } = string.Empty;
        public string PhoneNumber { get; private set; } = string.Empty;
        public int Floor { get; private set; }


        public List<Guid> rooms { get; private set; }= new List<Guid>();
        public List<Guid> employees { get; private set; } = new List<Guid>();
        public List<Guid> nurses { get; private set; } = new List<Guid>();
        public List<Guid> doctors { get; private set; } = new List<Guid>();
        public static Department Create(string name, string description, string location, string phoneNumber, int floor)
        => new Department(name, description, location, phoneNumber, floor);
        public void Update(string name, string description, string location, string phoneNumber, int floor,
            List<Guid> rooms, List<Guid> employees,List<Guid> nurses, List<Guid> doctors)
        {
            Name = name;
            Description = description;
            Location = location;
            PhoneNumber = phoneNumber;
            Floor = floor;
            this.rooms = rooms;
            this.employees = employees;
            this.nurses = nurses;
            this.doctors = doctors;





        }




    }
}
