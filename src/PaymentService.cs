namespace DesignPatternChallenge;

public class PaymentService
{
    private readonly IPaymentGatewayFactory _factory;

    public PaymentService(IPaymentGatewayFactory factory)
    {
        _factory = factory;
    }

    public void ProcessPayment(decimal amount, string cardNumber)
    {
        if(_factory == null)
        {
            throw new ArgumentException("Gateway não suportado");
        }

        var validator = _factory.CreateCardValidator();
        if (!validator.ValidateCard(cardNumber))
        {
            Console.WriteLine($"{_factory.GatewayName}: Cartão inválido");
            return;
        }
        
        var processor = _factory.CreateTransactionProcessor();
        var result = processor.ProcessTransaction(amount, cardNumber);
        
        var logger = _factory.CreateLogger();
        logger.Log($"Transação processada: {result}");
    }
}