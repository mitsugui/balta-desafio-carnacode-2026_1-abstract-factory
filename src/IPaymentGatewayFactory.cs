namespace AbstractFactoryChallenge;

public interface IPaymentGatewayFactory
{
    string GatewayName { get; }

    ICardValidator CreateCardValidator();
    ITransactionProcessor CreateTransactionProcessor();
    ILogger CreateLogger();
}
