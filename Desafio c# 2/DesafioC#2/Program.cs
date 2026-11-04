internal class Program
{
    private static void Main(string[] args)
    {
        string opcao = string.Empty;
        string placa,
            modelo,
            marca,
            identificacao,
            novaPlaca;
        int typeVeiculo;
        decimal novoSaldo,
            saldoObtido;
        decimal valorPedagio;
        Veiculo nomeVeiculo = null;
        Pedagio ped = new Pedagio();
        try
        {
            Console.WriteLine("Bem vindo ao Sistema de Tags de Veículos!");

            do
            {
                Console.WriteLine("\nInforme a Identificação da TAG:");
                identificacao = Console.ReadLine();

                if (string.IsNullOrEmpty(identificacao))
                {
                    Console.WriteLine("Erro: Campo não pode ser nulo ou vazio!");
                }
            } while (string.IsNullOrEmpty(identificacao));

            do
            {
                Console.WriteLine($"\nPlaca do veículo: ");
                placa = Console.ReadLine();

                if (string.IsNullOrEmpty(placa))
                {
                    Console.WriteLine("Erro: Campo não pode ser nulo ou vazio!");
                }
            } while (string.IsNullOrEmpty(placa));

            do
            {
                Console.WriteLine($"\nModelo do Veículo: ");
                modelo = Console.ReadLine();

                if (string.IsNullOrEmpty(modelo))
                {
                    Console.WriteLine("Erro: Campo não pode ser nulo ou vazio!");
                }
            } while (string.IsNullOrEmpty(modelo));

            do
            {
                Console.WriteLine($"\nMarca do Veículo: ");
                marca = Console.ReadLine();

                if (string.IsNullOrEmpty(marca))
                {
                    Console.WriteLine("Erro: Campo não pode ser nulo ou vazio!");
                }
            } while (string.IsNullOrEmpty(marca));

            bool tipoValido = false;

            do
            {
                Console.WriteLine($"Selecione um Veículo:\n1 - Moto\n2 - Carro\n3 - Caminhao\n");

                if (
                    int.TryParse(Console.ReadLine(), out typeVeiculo)
                    && Enum.IsDefined(typeof(TipoVeiculo), typeVeiculo)
                )
                {
                    tipoValido = true;
                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1, 2 ou 3.\n");
                }
            } while (tipoValido == false);

            nomeVeiculo = new Veiculo(placa, modelo, marca, (TipoVeiculo)typeVeiculo);

            if (ped.PassarPedagio() == true)
            {
                Tag novaTAG = new Tag(identificacao);

                nomeVeiculo.AssociarTAG(novaTAG);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
            return;
        }

        do
        {
            try
            {
                Console.WriteLine("\nSelecione uma Opção:\n");
                Console.WriteLine("\n1 - Carregar Tag");
                Console.WriteLine("\n2 - Verificar Saldo");
                Console.WriteLine("\n3 - Alterar Placa");
                Console.WriteLine("\n4 - Passar No Pedágio");
                Console.WriteLine("\n5 - Informações do Veículo");
                Console.WriteLine("\n6 - Relatórios");
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
                                throw new ArgumentException(
                                    "Valor menor ou igual a zero Tente Novamente! \n\n"
                                );
                            }

                            nomeVeiculo.Id.RecarregarTag(novoSaldo);
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine(
                                "Erro: Você digitou um texto. Insira apenas números maiores que 0."
                            );
                        }
                        finally
                        {
                            Console.WriteLine(
                                $"\nSeu saldo é: {nomeVeiculo.Id.ObterSaldo():C}\n\n"
                            );
                        }
                        break;
                    case "2":
                        saldoObtido = nomeVeiculo.Id.ObterSaldo();
                        Console.WriteLine($"\nSeu saldo é: {saldoObtido:C}\n\n");
                        break;
                    case "3":
                        Console.WriteLine($"Placa Atual: {nomeVeiculo.Placa}");
                        Console.WriteLine("Informe a Nova Placa:");
                        novaPlaca = Console.ReadLine();
                        nomeVeiculo.AlterarPlaca(novaPlaca);
                        break;
                    case "4":
                        try
                        {
                            // ALTERADO: o valor vem do Pedagio, sem o if/else duplicado
                            valorPedagio = Pedagio.ObterValor(nomeVeiculo.TipoVeiculo);

                            // Sem saldo: registra a TENTATIVA e interrompe
                            if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
                            {
                                Pedagio.Tentativas.Add(
                                    new TentativaPassagem(
                                        nomeVeiculo,
                                        valorPedagio,
                                        "Saldo Insuficiente"
                                    )
                                );
                                throw new Exception(
                                    $"Saldo Insuficiente, Recarregue! Saldo:{nomeVeiculo.Id.ObterSaldo():C}"
                                );
                            }

                            // Com saldo: cobra e registra a PASSAGEM (só depois de cobrar)
                            if (ped.VerificarCancela() == true && ped.PassarPedagio() == true)
                            {
                                nomeVeiculo.Id.DescontarSaldo(valorPedagio);
                                Pedagio.Passagens.Add(new Passagem(nomeVeiculo, valorPedagio)); // NOVO
                                Console.WriteLine(
                                    $"\nPedágio pago: {valorPedagio:C}\nSaldo atual: {nomeVeiculo.Id.ObterSaldo():C}\n"
                                );
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Erro: {ex.Message}");
                        }
                        break;
                    case "5":
                        Console.WriteLine(
                            $"Veículo:\n\nMarca: {nomeVeiculo.Marca}\nModelo: {nomeVeiculo.Modelo}\nPlaca: {nomeVeiculo.Placa}\nTipo: {nomeVeiculo.TipoVeiculo}\n\n"
                        );
                        break;
                    case "6":
                        Relatorios.Menu();
                        break;
                    case "S":
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
