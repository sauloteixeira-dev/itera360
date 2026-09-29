int opcao;
double saldo = 0;

do
{
    Console.WriteLine("\nBem vindo ao sistema de Pedágio!\n");
    Console.WriteLine("\nSelecione uma opção:\n1 - Carregar Saldo\n2 - Verificar Saldo\n3 - Passar na Cancela\n0 - Sair\n\n");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o Valor: \n");
            saldo = double.Parse(Console.ReadLine());

            carregarValor(saldo);
            break;
        case 2:
            exibirSaldo(saldo);
            break;
        case 3:

            if (verificaCancela(saldo) == true)
            {
                passarPedagio();
                Console.WriteLine("Cancela Aberta");
            }
            else
            {
                Console.WriteLine("Cancela fechada");
                Console.WriteLine($"Saldo insuficiente : {saldo}");
            }
            break;
        default:
            Console.WriteLine("\n\nPrograma encerrado\n\n");
            break;
    }

} while (opcao != 0);



void passarPedagio()
{
    saldo -= 2.9;
}


double carregarValor(double saldo)
{
    return saldo += saldo;
}

void exibirSaldo(double saldo)
{
    Console.WriteLine($"\nSeu Saldo é de: {saldo.ToString("f")}\n");
}

bool verificaCancela(double saldo)
{
    bool ok;
    if (saldo > 0 && saldo >= 2.90)
    {
        ok = true;
    }
    else
    {
        ok = false;
    }
    return ok;
}


