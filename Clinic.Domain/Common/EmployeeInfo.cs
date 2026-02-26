using Hospital.Domain.Enyities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Common
{
    public class EmployeeInfo: Person
    {
        private EmployeeInfo() { }
        public EmployeeInfo(Guid personId, Guid department, DateTime startwork, DateTime endwork, decimal salary) : base(personId)
        {
            PersonId = personId;
            DepartmentId = department;
            Startwork = startwork;
            EndWork = endwork;
            Salary = salary;
        }
        public Guid PersonId { get; protected set; }
        public Guid DepartmentId { get; protected set; }
        public DateTime Startwork { get; protected set; }
        public DateTime EndWork { get; protected set; }
        public decimal Salary { get; protected set; }
        public EmployeeInfo Create(Guid personId, Guid department, DateTime startwork, DateTime endwork, decimal salary)
       => new EmployeeInfo(personId, department, startwork, endwork, salary);
        public void Update(Guid personId, Guid departmentId, DateTime startwork, DateTime endwork, decimal salary)
        {
            PersonId = personId;
            DepartmentId = departmentId;
            Startwork = startwork;
            EndWork = endwork;
            Salary = salary;
        }
    }
}
