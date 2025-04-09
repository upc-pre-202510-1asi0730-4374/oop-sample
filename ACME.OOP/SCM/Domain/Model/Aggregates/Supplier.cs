﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACME.OOP.Shared.Domain.Model.ValueObjects;

namespace ACME.OOP.SCM.Domain.Model.Aggregates
{
    public class Supplier(string identifier, string name, Address address)
    {
        public string Identifier { get; } = identifier ?? throw new ArgumentNullException(nameof(identifier));
        public string Name { get; } = name ?? throw new ArgumentNullException(nameof(name)); 
        public Address Address { get; } = address ?? throw new ArgumentNullException(nameof(address));
    }
}
