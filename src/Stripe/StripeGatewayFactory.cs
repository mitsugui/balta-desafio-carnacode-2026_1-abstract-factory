namespace AbstractFactoryChallenge.Stripe;

public class StripeGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "Stripe";

    public ICardValidator CreateCardValidator() => new StripeValidator();

    public ITransactionProcessor CreateTransactionProcessor() => new StripeProcessor();

    public ILogger CreateLogger() => new StripeLogger();
}