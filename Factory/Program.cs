#region Create Order
using Factory.Factories;
using Factory.Models.Commerce;
using Factory.Models;

Console.Write("Recipient Country: ");
var recipientCountry = Console.ReadLine().Trim();

Console.Write("Sender Country: ");
var senderCountry = Console.ReadLine().Trim();

Console.Write("Total Order Weight: ");
var totalWeight = Convert.ToInt32(Console.ReadLine().Trim());

var order = new Order
{
    Recipient = new Address
    {
        To = "Filip Ekberg",
        Country = recipientCountry
    },

    Sender = new Address
    {
        To = "Someone else",
        Country = senderCountry
    },

    TotalWeight = totalWeight
};

order.LineItems.Add(new Item("Item1", "Item1", 100m), 1);
order.LineItems.Add(new Item("Item2", "Item2", 100m), 1);
#endregion

var cart = new ShoppingCart(order, new StandardShippingProviderFactory());

var shippingLabel = cart.Finalize();

Console.WriteLine(shippingLabel);