using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var Fiat = new CarroDeCorrida("Ferrari", "800");
        var GolBola = new Carro();





        Console.WriteLine($"A velocidade atual é: {Fiat.Velocidade}"); //A velocidade atual é: 10
    }
}
