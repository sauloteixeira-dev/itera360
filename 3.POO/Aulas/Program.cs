using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var Fiat = new Carro();

        //Fiat._cor = "Azul"
        //dará erro pois está privado _cor

        // Fiat.Velocidade = 125;

        Fiat.Acelerar();

        Console.WriteLine($"A velocidade atual é: {Fiat.Velocidade}"); //A velocidade atual é: 10
    }
}

//================================================================================== Aula 1 e 2 ==================================================================================
// bool acelere = false;
// CarroDeCorrida ferrari = new CarroDeCorrida();

// ferrari.Cor = "Vermelho";
// ferrari.Categoria = "F1";
// ferrari.Motor = "Ferrari";
// ferrari.Potencia = 800;

// ferrari.Ligar();

// CarroDeCorrida Mercedes = new CarroDeCorrida();

// Mercedes.Cor = "Cinza";
// Mercedes.Categoria = "F1";
// Mercedes.Motor = "Mercedes";
// Mercedes.Potencia = 800;

// Mercedes.Ligar();

// do
// {
//     System.Console.WriteLine("Digite S para acelerar");
//     if (Console.ReadLine() == "s")
//     {
//         acelere = true;

//         ferrari.Acelerar();
//         Mercedes.Acelerar();
//     }
//     else
//     {
//         acelere = false;
//     }
//     System.Console.WriteLine($"A velocidade da Ferrari é de: {ferrari.Velocidade}\n\nA velocidade da Mercedes é de: {Mercedes.Velocidade}");

// } while (acelere);

//================================================================================== Aula 3 ==================================================================================
// private static void Main(string[] args)
// {
//     Carro Fiat = new Carro("Fiat", "147", "Amarelo");

//     Console.WriteLine($"O modelo do carro é: {Fiat.Modelo}");
// }
//========================================== EXERCICIO AULA3 ==========================================
// private static void Main(string[] args)
// {
//    Funcionario func1 = new Funcionario("Saulo", 001, 3500m);

//      Console.WriteLine($"Funcionário 1: {func1.Nome} - Salário Atual: R$ {func1.Salario}"); // Resposta: Funcionário 1: Saulo - Salário Atual: R$ 3.500

//      func1.DarAumento(500)
//      Console.WriteLine($"Funcionário 1 após aumento: R$ {func1.Salario}"); //Resposta: Funcionário 1 após aumento: R$ 4.000

// }

//================================================================================== Aula 3 ==================================================================================
