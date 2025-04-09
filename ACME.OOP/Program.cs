// See https://aka.ms/new-console-template for more information
using ACME.OOP.Procurement.Domain.Model.Aggregates;
using ACME.OOP.SCM.Domain.Model.Aggregates;
using ACME.OOP.Shared.Domain.Model.ValueObjects;
using ACME.OOP.SCM.Domain.Model.ValueObjects;
using ACME.OOP.Procurement.Domain.Model.ValueObjects;

Console.WriteLine("Hello, World!");

var supplierAddress = new Address("Supplier Ave", "347", "SupCity", null, "10001", "United States");
var supplier = new Supplier("SUP001", "Microsoft, Inc.", supplierAddress);

var purchaseOrder = new PurchaseOrder("PO0001", new SupplierId(supplier.Identifier), DateTime.Now, "USD");
purchaseOrder.AddItem(ProductId.New(), 10, 25.99m);

Console.WriteLine($"Purchase Order {purchaseOrder.OrderNumber} created for " +
    $"Supplier ID {purchaseOrder.SupplierId.Identifier} in {purchaseOrder.Currency}");

foreach(var item in purchaseOrder.Items)
{
    Console.WriteLine($"Item Subtotal: {item.CalculateSubtotal().Amount} {item.CalculateSubtotal().Currency}");
}

Console.WriteLine($"Total: {purchaseOrder.CalculateTotal().Amount} {purchaseOrder.CalculateTotal().Currency}");
