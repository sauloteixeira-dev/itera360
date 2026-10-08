internal class Program
{
    private static void Main(string[] args)
    {

        var fiat = new CarroDeCorrida("Ferrari", "800");
        var fiorino = new CarroDeCarga();

        fiat.Acelerar();
        fiorino.Acelerar();

        System.Console.WriteLine($"A velocidade atual do Fiat é: {fiat.Velocidade}, da equipe: {fiat.Equipe}, motor: {fiat.Motor}");
        System.Console.WriteLine($"A velocidade atual da Fiorino é: {fiorino.Velocidade}");
    }
}