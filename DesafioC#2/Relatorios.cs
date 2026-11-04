public static class Relatorios
{
    public static void Menu()
    {
        string opcao;
        do
        {
            Console.WriteLine("\n=== RELATÓRIOS ===");
            Console.WriteLine("1 - Visualizar Passagens");
            Console.WriteLine("2 - Visualizar Tentativas");
            Console.WriteLine("0 - Voltar");
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1": VisualizarPassagens(); break;
                case "2": VisualizarTentativas(); break;
                case "0": break;
                default: Console.WriteLine("Opção inválida!"); break;
            }
        } while (opcao != "0");
    }

    private static void VisualizarPassagens()
    {
        // LINQ: ordena da mais recente para a mais antiga
        var ordenadas = Pedagio.Passagens.OrderByDescending(p => p.DataHora);

        if (!ordenadas.Any())
        {
            Console.WriteLine("\nNenhuma passagem registrada.");
            return;
        }

        foreach (var p in ordenadas)
        {
            Console.WriteLine($"{p.DataHora:dd/MM/yyyy HH:mm:ss} | Placa: {p.Veiculo.Placa} | Tag: {p.Veiculo.Id.Id} | Valor: {p.ValorPedagio:C}");
        }

        // LINQ: soma dos valores
        Console.WriteLine($"\nTotal arrecadado: {Pedagio.Passagens.Sum(p => p.ValorPedagio):C}");
    }

    private static void VisualizarTentativas()
    {
        Console.WriteLine("\nFiltrar por placa (Enter para ver todas):");
        string placa = Console.ReadLine();

        var tentativas = Pedagio.Tentativas.AsEnumerable();

        // LINQ: só filtra se o usuário digitou uma placa
        if (!string.IsNullOrWhiteSpace(placa))
        {
            tentativas = tentativas.Where(t =>
                string.Equals(t.Veiculo.Placa, placa.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        tentativas = tentativas.OrderByDescending(t => t.DataHora);

        if (!tentativas.Any())
        {
            Console.WriteLine("\nNenhuma tentativa encontrada.");
            return;
        }

        foreach (var t in tentativas)
        {
            Console.WriteLine($"{t.DataHora:dd/MM/yyyy HH:mm:ss} | Placa: {t.Veiculo.Placa} | Valor: {t.ValorPedagio:C} | Motivo: {t.Motivo}");
        }
    }
}