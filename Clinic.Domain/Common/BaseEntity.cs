using System.ComponentModel.DataAnnotations;

namespace Hospital.Domain.Common;

public abstract class BaseEntity
{
    protected BaseEntity() { }
    public Guid Id { get; protected set; } = Guid.NewGuid();
    public DateTime CreatedDate { get; private set; } = DateTime.UtcNow;
    [ConcurrencyCheck]
    public uint Xmin { get; internal set; }
}
