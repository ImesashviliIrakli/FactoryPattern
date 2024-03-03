using Factory.Providers;
using Factory.Providers.Base;

namespace Factory.Factories;

public class GlobalExpressShippingProviderFactory : ShippingProviderFactory
{
    public override ShippingProvider CreateShippingProvider(string country)
    {
        return new GlobalExpressShippingProvider();
    }
}