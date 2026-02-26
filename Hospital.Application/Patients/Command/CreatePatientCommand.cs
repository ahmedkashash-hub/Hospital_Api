using FluentValidation;
using Hospital.Contract;
using Hospital.Domain;
using Hospital.Domain.Enyities;
using Hospital.Infrastructure.Persistence;
using Phoenix.Mediator.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Application.Patients.Command
{
    public class CreatePatientCommand:IRequest
    {
        public Guid PersonId { get;  set; }
        public Guid DoctorId { get;  set; }
        public Guid DiseaseId { get;  set; }
        public int BookingNuber { get;  set; }
        public string Note { get;  set; } = string.Empty;

    }
    public class CreatePatientCommandValidator : AbstractValidator<CreatePatientCommand>
    {
        public CreatePatientCommandValidator()
        {
            RuleFor(x => x.PersonId).NotEmpty();
            RuleFor(x => x.DoctorId).NotEmpty();
            RuleFor(x => x.DiseaseId).NotEmpty();
            RuleFor(x => x.BookingNuber).GreaterThan(0);
        }
    }
    public class CreatePatientCommandHandler(IUnitOfWork unitOfWork) : IRequestHandler<CreatePatientCommand>
    {
        public async Task Handle(CreatePatientCommand request, CancellationToken cancellationToken)
        {

            IGenericRepository<Patient> repository = unitOfWork.GenericRepository<Patient>();

            Patient patient = Patient.create(request.PersonId, request.DoctorId, request.BookingNuber, request.Note);
            await repository.Create(patient, cancellationToken);
            await unitOfWork.SaveChangesAsync(cancellationToken);
        }
    }
}
