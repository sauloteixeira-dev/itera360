using Microsoft.VisualBasic;

public class Program
{

    private static void Main(string[] args)
    {

        string nome;
        int opcao;

        Console.WriteLine("Cadastrar Jogador");
        Console.WriteLine("Informe seu nome: ");
        nome = Console.ReadLine();
        var NovoJogador = new Jogador(nome);
        var NovaPartida = new Partida(NovoJogador);

        Console.WriteLine($"Esse é o nome: {NovoJogador.Nome}");

        do
        {
            Console.WriteLine("Informe uma opção: ");

            Console.WriteLine("1 - Jogar");
            Console.WriteLine("2 - Exibir ranking");
            Console.WriteLine("");
            Console.WriteLine("0 - Sair");
            opcao = int.Parse(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                NovaPartida.JogadaJogador();
                NovaPartida.JogadaComputador();
                



                    break;
                case 2:
                    //aqui entra ranking
                    Console.WriteLine($"Nome: {NovoJogador.Nome}");
                    Console.WriteLine($"Vitórias: {NovoJogador.Vitorias}");
                    Console.WriteLine($"Derrotas: {NovoJogador.Derrotas}");
                    Console.WriteLine(opcao);
                    break;
                case 0:
                    opcao = 0;
                    break;
                default:
                    Console.WriteLine("Opção incorreta!");
                    break;
            }
        } while (opcao != 0);




    }
}