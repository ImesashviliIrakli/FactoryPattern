using Factory.Factories;
using Factory.Models.Commerce;
using Factory.Models.Enums;

namespace Factory.Models;

public class ShoppingCart
{
    private readonly Order order;
    private readonly ShippingProviderFactory shippingProviderFactory;

    public ShoppingCart(Order order, ShippingProviderFactory shippingProviderFactory)
    {
        this.order = order;
        this.shippingProviderFactory = shippingProviderFactory;
    }

    public string Finalize()
    {
        var shippingProvider = shippingProviderFactory.CreateShippingProvider(order.Sender.Country);

        order.ShippingStatus = ShippingStatus.ReadyForShippment;

        return shippingProvider.GenerateShippingLabelFor(order);
    }
}
