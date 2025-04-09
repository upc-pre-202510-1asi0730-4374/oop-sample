using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.Procurement.Domain.Model.Aggregates
{
    public class PurchaseOrderItem(ProductId productId, int quantity, Money money)
    {
        public ProductId ProductId { get; }
    }
}
