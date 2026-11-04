public static class Relatorio
{
    public static void Menu()
    {
        string opcao;
        do
        {
            Console.WriteLine("\n------Relatórios------\n");
            Console.WriteLine("\n1 - Visualizar Passagens ");
            Console.WriteLine("\n2 - Visualizar Tentativas ");
            Console.WriteLine("\n0 - Voltar para o menu anterior\n\n");
            opcao = Console.ReadLine();
            switch (opcao)
            {
                case "1":
                    VisualizarPassagens();
                    break;
                case "2":
                    VisualizarTentativas();
                    break;
                case "0":
                    Console.WriteLine("\nVoltando...\n");
                    break;
                default: Console.WriteLine("\nOpção inválida!\n.ToUpper()"); break;
            }
        } while (opcao != "0");


    }
    private static void VisualizarPassagens()
    {
        var listaOrdenada = Pedagio.Passagem.OrderByDescending(passou => passou.dataHora);
        if (!listaOrdenada.Any())
        {
            Console.WriteLine("\n\nNenhuma passagem registrada!\n\n".ToUpper());
            return;
        }
        foreach (var passagens in listaOrdenada)
        {
            Console.WriteLine($"Hora: {passagens.dataHora:dd/MM/yy HH:mm} | Placa: {passagens.Veiculo.Placa} | Tag: {passagens.Veiculo.Id} | Valor: {passagens.ValorPedagio:C}");
        }
        Console.WriteLine($"\nTotal Arrecadado: {Pedagio.Passagem.Sum(p => p.ValorPedagio):C}");
    }

    private static void VisualizarTentativas()
    {
        Console.WriteLine("\nDigite a placa para filtrar por placa (Enter para ver todas):\n");
        string placa = Console.ReadLine();
        var tentativas = Pedagio.TentativaPassagem.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(placa))
        {
            tentativas = tentativas.Where(t => string.Equals(t.Veiculo.Placa, placa.Trim(), StringComparison.OrdinalIgnoreCase));
        }
        tentativas = tentativas.OrderByDescending(t => t.dataHora);
        if (!tentativas.Any())
        {
            Console.WriteLine("\n\nNenhuma tentativa encontrada!\n\n".ToUpper());
        }
        foreach (var tentativa in tentativas)
        {
            Console.WriteLine($"{tentativa.dataHora: dd/MM/yy HH:mm} | Placa: {tentativa.Veiculo.Placa} | Valor: {tentativa.ValorPedagio:C} | Motivo: {tentativa.Motivo}");
        }
    }
}