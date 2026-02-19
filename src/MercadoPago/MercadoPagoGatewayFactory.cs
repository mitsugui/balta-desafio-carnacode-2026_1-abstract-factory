namespace DesignPatternChallenge.MercadoPago;

public class MercadoPagoGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "MercadoPago";

    public ICardValidator CreateCardValidator() => new MercadoPagoValidator();

    public ITransactionProcessor CreateTransactionProcessor() => new MercadoPagoProcessor();

    public ILogger CreateLogger() => new MercadoPagoLogger();
}