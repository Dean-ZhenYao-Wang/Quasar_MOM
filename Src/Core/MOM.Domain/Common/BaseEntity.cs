using System;

namespace MOM.Domain.Common
{
    public abstract class BaseEntity
    {
        public string DtId { get; set; } = Guid.NewGuid().ToString();
    }
}
