﻿using Factory.Providers.Base;

namespace Factory.Factories;

public abstract class ShippingProviderFactory
{
    public abstract ShippingProvider CreateShippingProvider(string country);

    public ShippingProvider GetShippingProvider(string country)
    {
        var provider = CreateShippingProvider(country);

        if (country == "Sweden" &&
            provider.InsuranceOptions.ProviderHasInsurance)
        {
            provider.RequireSignature = false;
        }

        return provider;
    }
}
