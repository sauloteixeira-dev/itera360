public class Program
{
    private static void Main(string[] args)
    {
        int opcaoInvalida = -1;
        int opcao = opcaoInvalida;
        var ranking = new Ranking();
        string nomeJogador,
            resultado,
            nomeNovoJogador,
            continuar;

        do
        {
            ExibirMenu();

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                opcao = opcaoInvalida;
            }

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Informe o nome do jogador: ");
                    nomeNovoJogador = Console.ReadLine();

                    if (ranking.BuscarJogador(nomeNovoJogador) == null)
                    {
                        var novoJogador = new Jogador(nomeNovoJogador);
                        ranking.AdicionarJogador(novoJogador);
                        Console.WriteLine($"Jogador {novoJogador.Nome} cadastrado!");
                    }
                    else
                    {
                        Console.WriteLine("Já existe um jogador com esse nome.");
                    }
                    break;
                case 2:
                    Console.WriteLine("Informe o nome do jogador: ");
                    nomeJogador = Console.ReadLine();
                    Jogador jogadorEncontrado = ranking.BuscarJogador(nomeJogador);

                    if (jogadorEncontrado == null)
                    {
                        Console.WriteLine("Jogador não encontrado. Vá até (opção 1).");
                    }
                    else
                    {
                        var partida = new Partida(jogadorEncontrado);

                        do
                        {
                            var jogadaJogador = partida.JogadaJogador();
                            Console.WriteLine();
                            var jogadaComputador = partida.JogadaComputador();
                            resultado = Utilitario.CalcularResultado(
                                jogadaJogador,
                                jogadaComputador
                            );

                            Console.WriteLine();
                            Console.WriteLine("------------------------------");
                            Console.WriteLine($"  Resultado: {resultado}");
                            Console.WriteLine("------------------------------");
                            Console.WriteLine();
                            partida.AtualizarPlacar(resultado);

                            Console.Write(
                                "Digite 0 para voltar ao menu ou Enter para jogar de novo: "
                            );
                            continuar = Console.ReadLine();
                            Console.WriteLine();
                        } while (continuar != "0");
                    }
                    break;
                case 3:
                    ranking.ExibirRanking();
                    break;
                case 0:
                    Console.WriteLine("Saindo...");
                    break;
                default:
                    Console.WriteLine("Opção incorreta!");
                    break;
            }
        } while (opcao != 0);
    }

    private static void ExibirMenu()
    {
        Console.WriteLine("==============================");
        Console.WriteLine("           JOKEMPO            ");
        Console.WriteLine("==============================");

        Console.WriteLine("  1 - Cadastrar jogador");
        Console.WriteLine("  2 - Jogar");
        Console.WriteLine("  3 - Exibir ranking");
        Console.WriteLine("------------------------------");
        Console.WriteLine("  0 - Sair");
        Console.WriteLine("==============================");
        Console.Write("Escolha uma opção: ");
    }
}
