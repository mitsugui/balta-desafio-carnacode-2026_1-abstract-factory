using AbstractFactoryChallenge;
using AbstractFactoryChallenge.MercadoPago;
using AbstractFactoryChallenge.PagSeguro;


Console.WriteLine("=== Sistema de Pagamentos ===\n");

// Problema: Cliente precisa saber qual gateway está usando
// e o código de processamento está todo acoplado
var pagSeguroService = new PaymentService(new PagSeguroGatewayFactory());
pagSeguroService.ProcessPayment(150.00m, "1234567890123456");

Console.WriteLine();

var mercadoPagoService = new PaymentService(new MercadoPagoGatewayFactory());
mercadoPagoService.ProcessPayment(200.00m, "5234567890123456");

Console.WriteLine();