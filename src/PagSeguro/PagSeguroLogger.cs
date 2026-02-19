namespace DesignPatternChallenge.PagSeguro;

public class PagSeguroLogger : ILogger
{
    public void Log(string message)
    {
        Console.WriteLine($"[PagSeguro Log] {DateTime.Now}: {message}");
    }
}