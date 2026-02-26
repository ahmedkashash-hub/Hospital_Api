using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Doctor:EmployeeInfo
    {
       private Doctor() { }
     public Doctor(List<Guid> RoomId, List<Patient> patients, string specialization, int yearExper, string password, string userName) :base(Guid personId, Guid department, DateTime startwork, DateTime endwork, decimal salary) 

        {
            this.RoomId = RoomId;
            this.Patients = patients;
            this.Specialization = specialization;
            this.YearExper = yearExper;
            this.Password = password;
            this.UserName = userName;
        }

        public const string AdminEmail = "admin@admin.com";
        public List<Guid> RoomId { get; private set; } = new List<Guid>();
        public List<Patient> Patients { get; protected set; } = new List<Patient>();
        public string Specialization { get; private set; } = string.Empty;
        public int YearExper { get; private set; } 
        public string Password { get; private set; } =  string.Empty;
        public string UserName { get; private set; }= string.Empty;


        public Doctor Create(Guid personId, Guid DepartMentId, string specialization, int yearExper, DateTime startwork, DateTime endwork, decimal salary, string password, string userName) => new Doctor(new List<Guid>(), new List<Patient>(), specialization, yearExper, password, userName)=>new Doctor()
        



    public void Update
           (Guid personId, Guid DepartMentId, string specialization, int yearExper, DateTime startwork, DateTime endwork, decimal salary, List<Patient> patients, string password, string userName)
        {
            Startwork = startwork;
            EndWork = endwork;
            Salary = salary;
            Patients = new List<Patient>();
            Specialization = specialization;
            PersonId = personId;
            DepartmentId = DepartMentId;
            YearExper = yearExper;
            Password = password;
                UserName = userName;







        }

    }
}
