using FluentValidation;
using Hospital.Contract;
using Hospital.Domain.Enyities;
using Hospital.Infrastructure.Persistence;
using Phoenix.Mediator.Abstractions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Hospital.Application.Employees.Command
{
    public class CreateEmployeeCommand : IRequest
    {
        public Guid PersonId { get; set; }
        public Guid Department { get; set; }
        public DateTime Startwork { get; set; }
        public DateTime EndWork { get; set; }
        public decimal Salary { get; set; }

    }
    public class CreateEmployeeCommandValidator : AbstractValidator<CreateEmployeeCommand>
    {
        public CreateEmployeeCommandValidator()
        {
            RuleFor(x => x.PersonId).NotEmpty();
            RuleFor(x => x.Department).NotEmpty();
            RuleFor(x => x.Startwork).NotEmpty();
            RuleFor(x => x.EndWork).NotEmpty();
            RuleFor(x => x.Salary).GreaterThan(0);
        }
    }
    public class CreateEmployeeCommandHandler(UnitOfWork unitOfWork) : IRequestHandler<CreateEmployeeCommand>
    {
       
      
        public async Task Handle(CreateEmployeeCommand request, CancellationToken cancellationToken)
        {
            IGenericRepository<Employee> repository = unitOfWork.GenericRepository<Employee>();

            Employee employee = Employee.Create(request.PersonId, request.Department, request.Startwork, request.EndWork, request.Salary);
            await repository.Create(employee,cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }



    }
}
