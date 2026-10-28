internal class Program
{
    private static void Main(string[] args)
    {

        string opcao = string.Empty;
        string placa, modelo, marca, identificacao, novaPlaca;
        int typeVeiculo;
        decimal novoSaldo, saldoObtido;
        decimal valorPedagio;
        Veiculo nomeVeiculo = null;
        try
        {
            Console.WriteLine("Bem vindo ao Sistema de Tags de Veículos!");

            Console.WriteLine("\nInforme a Identificação da TAG:");
            identificacao = Console.ReadLine();

            Console.WriteLine($"\nPlaca do veículo: ");
            placa = Console.ReadLine();

            Console.WriteLine($"\nModelo do Veículo: ");
            modelo = Console.ReadLine();

            Console.WriteLine($"\nMarca do Veículo: ");
            marca = Console.ReadLine();

            if (string.IsNullOrEmpty(identificacao) || string.IsNullOrEmpty(placa) || string.IsNullOrEmpty(marca))
            {
                throw new Exception("Campo não pode ser nulo ou vazio!");
            }

            Console.WriteLine($"Selecione um Veículo:\n1 - Moto\n2 - Carro\n3 - Caminhao\n");
            typeVeiculo = Convert.ToInt32(Console.ReadLine());

            if (typeVeiculo > 1 || typeVeiculo < 3) //AQUIIIIIIIIII
            {
                switch ((TipoVeiculo)typeVeiculo)
                {
                    case TipoVeiculo.Moto:
                        nomeVeiculo.TipoVeiculo = "Moto";
                        break;
                    case TipoVeiculo.Carro:
                        nomeVeiculo.TipoVeiculo = "Carro";
                        break;
                    case TipoVeiculo.Caminhao:

                        nomeVeiculo.TipoVeiculo = "Caminhão";
                        break;
                }
            }
            else
            {
                throw new Exception("Valor não existe!");
            }
            //ALTERAR PARA NÃO PASSAR SE ERRAR O NUMERO 1 OU 2 OU 3 ESTÁ PASSANDO!!!!!!!!!!!!

            nomeVeiculo = new Veiculo(placa, modelo, marca);

            //cria Pedágio
            var ped = new Pedagio();

            if (ped.PassarPedagio() == true)
            {
                Tag novaTAG = new Tag(identificacao);

                nomeVeiculo.AssociarTAG(novaTAG);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
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
                        if (nomeVeiculo.TipoVeiculo == "Moto")
                        {
                            valorPedagio = 1.50m;

                            if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
                            {
                                Console.WriteLine("Saldo Insuficiente!");
                            }
                            else
                            {
                                nomeVeiculo.Id.DescontarSaldo(valorPedagio);
                            }


                        }
                        if (nomeVeiculo.TipoVeiculo == "Carro")
                        {
                            valorPedagio = 2.90m;
                            if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
                            {
                                Console.WriteLine("Saldo Insuficiente!");
                            }
                            else
                            {
                                nomeVeiculo.Id.DescontarSaldo(valorPedagio);
                            }

                        }
                        if (nomeVeiculo.TipoVeiculo == "Caminhão")
                        {
                            valorPedagio = 18.90m;
                            if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
                            {
                                Console.WriteLine("Saldo Insuficiente!");
                            }
                            else
                            {
                                nomeVeiculo.Id.DescontarSaldo(valorPedagio);
                            }

                        }
                        break;
                    case "5":
                        Console.WriteLine($"Veículo:\n\nMarca: {nomeVeiculo.Marca}\nModelo: {nomeVeiculo.Modelo}\nPlaca: {nomeVeiculo.Placa}\nTipo: {nomeVeiculo.TipoVeiculo}\n\n");
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

// try
//                                 {
//                                     if (nomeVeiculo.Id.ObterSaldo() < valorPedagio)
//                                     {
//                                         throw new Exception("Saldo Insuficiente, Recarregue!");
//                                     }
//                                     nomeVeiculo.Id.DescontarSaldo(valorPedagio);
//                                 }
//                                 catch (Exception ex)
//                                 {
//                                     Console.WriteLine($"Erro: {ex.Message}");
//                                 }