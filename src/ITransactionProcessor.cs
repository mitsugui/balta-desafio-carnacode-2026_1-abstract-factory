namespace DesignPatternChallenge;

public interface ITransactionProcessor
{
    string ProcessTransaction(decimal amount, string cardNumber);
}