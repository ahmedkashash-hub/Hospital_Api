using Hospital.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hospital.Domain.Enyities
{
   public class Visit: BaseEntity
    {
        public Guid RoomId { get; private set; }
        public DateTime VisitDate { get; private set; }
        public string Note { get; private set; } = string.Empty;
        public Visit Create(Guid RoomId, DateTime visitDate, string note)
        {
            return new Visit
            {
                RoomId = RoomId,
                VisitDate = visitDate,
                Note = note
            };
        }
        public void Update(Guid RoomId, DateTime visitDate, string note)
        {
            
            this.RoomId = RoomId;
            this.VisitDate = visitDate;
            this.Note = note;
        }
        }
}
