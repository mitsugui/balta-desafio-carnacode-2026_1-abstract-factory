namespace DesignPatternChallenge.PagSeguro;

public class PagSeguroGatewayFactory : IPaymentGatewayFactory
{
    public string GatewayName => "PagSeguro";

    public ICardValidator CreateCardValidator() => new PagSeguroValidator();

    public ITransactionProcessor CreateTransactionProcessor() => new PagSeguroProcessor();

    public ILogger CreateLogger() => new PagSeguroLogger();
}