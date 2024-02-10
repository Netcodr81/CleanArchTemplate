using CleanArchTemplate.BlazorWASM.Domain.Common;

namespace CleanArchTemplate.BlazorWASM.Domain.Abstractions;

public abstract class AuditableEntity<T> : Entity<T>
{
    public DateTime CreatedAt { get; set; }
    public string CreatedBy { get; set; } = null!;
    public DateTime? LastModifiedAt { get; set; }
    public string? LastModifiedBy { get; set; }
}