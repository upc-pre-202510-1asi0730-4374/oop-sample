﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.OOP.Procurement.Domain.Model.ValueObjects;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.Procurement.Domain.Model.Aggregates
{
    public class PurchaseOrderItem(ProductId productId, int quantity, Money unitPrice)
    {
        public ProductId ProductId { get; } = productId ?? throw new ArgumentNullException(nameof(productId));
        public int Quantity { get; } = quantity > 0 ? quantity : throw new ArgumentOutOfRangeException(nameof(quantity));
        public Money UnitPrice {  get; } = unitPrice ?? throw new ArgumentNullException(nameof(unitPrice));

        public Money CalculateSubtotal()
        {
            return new Money(Quantity * UnitPrice.Amount, UnitPrice.Currency);
        }

    }
}
