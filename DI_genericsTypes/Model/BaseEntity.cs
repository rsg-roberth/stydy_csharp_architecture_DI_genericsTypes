using System;

namespace DI_genericsTypes.Model
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public BaseEntity()
        {
            Id = Guid.NewGuid();
        }
    }
}
