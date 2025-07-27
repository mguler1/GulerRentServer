﻿
namespace GulerRentServer.Domain.Abstractions
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = new IdentityId(Guid.CreateVersion7());
            IsActive = true;
        }
        public IdentityId Id { get; private set; }
        public bool IsActive { get; private set; }
        public DateTimeOffset CreatedAt { get; private set; }
        public DateTimeOffset? UpdatedAt { get; private set; }
        public IdentityId CreatedBy { get; private set; }=default!;
        public IdentityId? UpdatedBy { get; private set; }
        public bool IsDeleted { get; private set; }

        public void SetStatus(bool isActive)
        {
            IsActive = isActive;
        }
        public void Delete()
        {
            IsDeleted = true;
            IsActive = false;
        }
    }
    public sealed record class IdentityId(Guid Value)
    {
        public static implicit operator Guid(IdentityId id) => id.Value;
        public static implicit operator string(IdentityId id) => id.Value.ToString();
    }
}
