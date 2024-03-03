using Factory.Models.Commerce;
using Factory.Providers.Base;

namespace Factory.Providers;

public class GlobalExpressShippingProvider : ShippingProvider
{
    public override string GenerateShippingLabelFor(Order order)
    {
        return "GLOBAL-EXPRESS";
    }
}
