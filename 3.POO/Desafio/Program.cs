
internal class Program
{
    // string opcao;

    private static void Main(string[] args)
    {
        string opcao;
        string placa, modelo, marca, identificacao, novaPlaca;
        decimal novoSaldo, saldoObtido;
        
        Console.WriteLine("Bem vindo ao Sistema de Tags de Veículos!");
        Console.WriteLine("\nVamos começar?");

        //Criar Tag
        Console.WriteLine("\nInforme a Identificação da TAG:");
        identificacao = Console.ReadLine();
        Tag novaTAG = new Tag(identificacao);

        //Cria Carro
        Pedagio pedagio = new Pedagio();

        Console.WriteLine($"\nInforme: ");

        Console.WriteLine($"\nPlaca do veículo: ");
        placa = Console.ReadLine();

        Console.WriteLine($"\nModelo do Veículo: ");
        modelo = Console.ReadLine();

        Console.WriteLine($"\nMarca do Veículo: ");
        marca = Console.ReadLine();

        Veiculo nomeVeiculo = new Veiculo(placa, modelo, marca);

        //Associar TAG
        nomeVeiculo.AssociarTAG(novaTAG);

        do
        {
            Console.WriteLine("\nSelecione uma Opção:\n");
            Console.WriteLine("\n1 - Carregar Tag");
            Console.WriteLine("\n2 - Verificar Saldo");
            Console.WriteLine("\n3 - Alterar Placa");
            Console.WriteLine("\n4 - Passar No Pedágio");
            Console.WriteLine("\n5 - Informações do Veículo");
            Console.WriteLine("\ns - Sair");
            opcao = Console.ReadLine().ToLower();

            switch (opcao)
            {
                case "1":
                    Console.WriteLine("\nInforme o Valor para carregar o saldo: ");
                    novoSaldo = decimal.Parse(Console.ReadLine());
                    nomeVeiculo._id.RecarregarTag(novoSaldo);
                    Console.WriteLine($"\nSeu saldo é: {nomeVeiculo._id.ObterSaldo()}\n\n");
                    break;
                case "2":
                    saldoObtido = nomeVeiculo._id.ObterSaldo();
                    Console.WriteLine($"\nSeu saldo é: {saldoObtido}\n\n");
                    break;
                case "3":
                    Console.WriteLine("Informe a Nova Placa:");
                    novaPlaca = Console.ReadLine();
                    nomeVeiculo.AlterarPlaca(novaPlaca);
                    break;
                case "4":
                    if (pedagio.PassarPedagio(nomeVeiculo) == true)
                    {
                        nomeVeiculo._id.DescontarSaldo(2.90m);
                        Console.WriteLine($"\n\n{nomeVeiculo} Passou com Sucesso!\n\n");
                    }
                    else
                    {
                        Console.WriteLine("\nVoce está sem saldo! Recarregue para continuar!\n\n");
                    }
                    break;
                case "5":
                    Console.WriteLine($"Veículo:\n\nMarca: {nomeVeiculo.Marca}\nModelo: {nomeVeiculo.Modelo}\nPlaca: {nomeVeiculo.Placa}\n\n");
                    break;
                    case "s":   
                    opcao = "s";
                    break;
                default:
                    Console.WriteLine("\n\nOpção inválida! Tente novamente\n\n");
                    break;
            }
        } while (opcao != "s");
    }
}