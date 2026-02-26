using Hospital.Domain.Common;

namespace Hospital.Domain.Enyities
{
    public class Nurse:EmployeeInfo
    {
        private Nurse() { }
        public Nurse(List<Guid> RoomId, List<Patient> patients, Guid personId, Guid department, DateTime startwork, DateTime endwork, decimal salary
            ) : base(personId, department, startwork, endwork, salary);
       public List<Guid> RoomId { get; private set; } = new List<Guid>();
        public List<Patient> Patients { get; protected set; } = new List<Patient>();
        public Nurse Add(Guid personId, Guid Department, DateTime startwork,List<Guid> RoomId, DateTime endwork, decimal salary)
        {

            return new Nurse
            {

                PersonId = personId,
                DepartmentId = Department,
                Startwork = startwork,
                EndWork = endwork,
                RoomId= RoomId,
                Salary = salary,
                Patients = new List<Patient>()
            };
        }
        public void Update(Guid personId, Guid department, DateTime startwork, DateTime endwork, List<int> RoomIdsw, decimal salary,List<Patient> patients)
        {



            PersonId = personId;
            DepartmentId = department;
            Startwork = startwork;
            EndWork = endwork;
            Salary = salary;
            this.RoomId = RoomId;
            
            Patients = patients;

        }
        }  }




