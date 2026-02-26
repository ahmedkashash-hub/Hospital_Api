using Hospital.Domain.Common;
using Hospital.Domain.Enyities.PatientInfo;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class Employee :   EmployeeInfo
    {
        private Employee() { }
      


        public static Employee Create(Guid personId, Guid Department, DateTime Startwork, DateTime EndWork, decimal Salary)
        {
            return new Employee {
              PersonId = personId,
              DepartmentId = Department,
              Startwork = Startwork,
              EndWork = EndWork,
              Salary = Salary
            };
        }
        
  
            public void Update(Guid PersonId, Guid Department, DateTime Startwork, DateTime EndWork, decimal Salary)
        {


               this.PersonId = PersonId;
               this.DepartmentId = Department;
               this.Startwork = Startwork;
               this.EndWork = EndWork;
               this.Salary =Salary;



            }

        }
    }
