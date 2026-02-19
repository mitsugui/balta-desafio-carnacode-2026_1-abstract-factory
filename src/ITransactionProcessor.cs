namespace AbstractFactoryChallenge;

public interface ITransactionProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}