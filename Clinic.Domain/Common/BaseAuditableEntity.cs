

namespace Hospital.Domain.Common;

public abstract class BaseAuditableEntity : BaseEntity
{
    public Guid CreatedById { get; private set; }
    public void AuditCreate(Guid createdById)
    {
        CreatedById = createdById;
    }
    public void AuditUpdate(Guid updatedById)
    {
        UpdatedById = updatedById;
        UpdatedDate = DateTime.UtcNow;
    }
    public Guid? UpdatedById { get; private set; }
    public DateTime? UpdatedDate { get; private set; }
}