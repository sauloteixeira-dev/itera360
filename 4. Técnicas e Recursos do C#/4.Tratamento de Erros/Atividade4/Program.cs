internal class Program
{

    private static void Main(string[] args)
    {

        string opcao = string.Empty;
        string placa, modelo, marca, identificacao, novaPlaca;
        decimal novoSaldo, saldoObtido;
        decimal valorPedagio = 2.90m;
        Veiculo nomeVeiculo;


        do
        {
            try
            {

                Console.WriteLine("Bem vindo ao Sistema de Tags de Veículos!");

                Console.WriteLine("\nInforme a Identificação da TAG:");
                identificacao = Console.ReadLine();
                if (string.IsNullOrEmpty(identificacao))
                {
                    throw new ArgumentException($"Campo Identificação não pode ser nulo ou vazio!");
                }
                new Pedagio();

                Console.WriteLine($"\nPlaca do veículo: ");
                placa = Console.ReadLine();
                if (string.IsNullOrEmpty(placa))
                {
                    throw new ArgumentException($"Campo Placa não pode ser nulo ou vazio!");
                }

                Console.WriteLine($"\nModelo do Veículo: ");
                modelo = Console.ReadLine();
                if (string.IsNullOrEmpty(modelo))
                {
                    throw new ArgumentException($"Campo Modelo não pode ser nulo ou vazio!");
                }

                Console.WriteLine($"\nMarca do Veículo: ");
                marca = Console.ReadLine();
                if (string.IsNullOrEmpty(marca))
                {
                    throw new ArgumentException($"Campo Marca não pode ser nulo ou vazio!");
                }

                nomeVeiculo = new Veiculo(placa, modelo, marca);

                Tag novaTAG = new Tag(identificacao);

                nomeVeiculo.AssociarTAG(novaTAG);


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
                        try
                        {
                            novoSaldo = decimal.Parse(Console.ReadLine());

                            if (novoSaldo <= 0)
                            {
                                throw new ArgumentException("Valor menor ou igual a zero Tente Novamente! \n\n");
                            }

                            nomeVeiculo.Id.RecarregarTag(novoSaldo);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Erro: Você digitou um texto. Insira apenas números maiores que 0.");
                        }
                        finally
                        {
                            Console.WriteLine($"\nSeu saldo é: {nomeVeiculo.Id.ObterSaldo():C}\n\n");
                        }
                        break;
                    case "2":
                        saldoObtido = nomeVeiculo.Id.ObterSaldo();
                        Console.WriteLine($"\nSeu saldo é: {saldoObtido}\n\n");
                        break;
                    case "3":
                        Console.WriteLine("Informe a Nova Placa:");
                        novaPlaca = Console.ReadLine();
                        nomeVeiculo.AlterarPlaca(novaPlaca);
                        break;
                    case "4":
                        try
                        {
                            if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
                            {
                                throw new InvalidOperationException("Saldo Insuficiente! Recarregue para continuar!");
                            }

                            nomeVeiculo.Id.DescontarSaldo(valorPedagio);

                            Console.WriteLine($"\n\n{nomeVeiculo} Passou com Sucesso!\n\n");
                        }
                        catch (InvalidOperationException ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}\n\n");
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


            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro: {ex.Message} ");
            }
        } while (opcao != "s");
    }
}