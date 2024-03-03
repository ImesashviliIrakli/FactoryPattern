using Factory.Models.Commerce;

namespace Factory.Providers.Base;

public abstract class ShippingProvider
{
    public ShippingCostCalculator ShippingCostCalculator { get; protected set; }
    public CustomsHandlingOptions CustomsHandlingOptions { get; protected set; }
    public InsuranceOptions InsuranceOptions { get; protected set; }

    public bool RequireSignature { get; set; }

    public abstract string GenerateShippingLabelFor(Order order);
}