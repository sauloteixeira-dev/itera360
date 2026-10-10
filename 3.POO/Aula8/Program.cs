internal class Program
{
    private static void Main(string[] args)
    {

        var fiat = new CarroDeCorrida();
        var fiorino = new CarroDeCarga();

        fiat.Acelerar();
        fiorino.Acelerar();

        System.Console.WriteLine($"A velocidade atual do Fiat é: {fiat.Velocidade}");
        System.Console.WriteLine($"A velocidade atual da Fiorino é: {fiorino.Velocidade}");
        System.Console.WriteLine($"Cor: {fiat.Cor} ");
    }
}