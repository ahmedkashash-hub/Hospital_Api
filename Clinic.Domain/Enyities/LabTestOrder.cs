using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
    public class LabTestOrder : BaseDeletableEntity
    {

        private LabTestOrder() { }
        public LabTestOrder(Guid patientId, Guid labTestId, string? status,string result,string note)
        {
            PatientId = patientId;
            LabTestId = labTestId;
            Result = result;
             Note = note;

            Status = status;
        }

        public Guid? PatientId { get; private set; }
        public Guid? LabTestId { get; private set; }

        public string? Status { get; private set; }
        public string? Result { get; private set; }
        public string Note { get; private set; } = string.Empty;
        public LabTestOrder Add(Guid patientId, Guid labTestId, string? status, string result, string note) => 
            new LabTestOrder(patientId, labTestId, status, result, note);

        public void Update(Guid patientId, Guid labTestId, string? status, string result, string note)
        {
            PatientId = patientId;
            LabTestId = labTestId;
            Status = status;
                Result = result;
                Note = note;

        }
    }
}
