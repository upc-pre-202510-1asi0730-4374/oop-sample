using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.OOP.Procurement.Domain.Model.ValueObjects
{
    public record ProductId
    {
        public Guid Id { get; init; }

        public ProductId(Guid id)
        {
            if (id == Guid.Empty)
            {
                throw new ArgumentException("ProductId cannot be an empty GUID.", nameof(id));
            }

            Id = id;
        }
        
        public static ProductId New() => new(Guid.NewGuid());

    }
}
