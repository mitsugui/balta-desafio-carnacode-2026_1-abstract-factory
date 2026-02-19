namespace DesignPatternChallenge.PagSeguro;

public class PagSeguroValidator : ICardValidator
{
    public bool ValidateCard(string cardNumber) 
    {
        Console.WriteLine("PagSeguro: Validando cartão...");
        return cardNumber.Length == 16;
    }
}
