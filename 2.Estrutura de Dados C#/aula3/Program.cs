string[] clientes = new string[5];
int opcao;
string pessoa;
int inicio = 0;
int fim = -1;

do
{
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine("\n1 - Adicionar Cliente na fila\n2 - Cliente atendido (remover)\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("=========================================");
            Console.WriteLine("Infome o nome do Cliente: ");
            pessoa = Console.ReadLine();
            Enfileirar(pessoa);
            break;
        case 2:
            Console.WriteLine("=========================================");
            Console.WriteLine("Removendo pessoa atendida: ");
            AtenderCliente();
            break;
    }

} while (opcao != 0);



void Enfileirar(string cliente)
{
    if (fim < 4)
    {
        fim++;
        clientes[fim] = cliente;
        Console.WriteLine("=========================================");
        Console.WriteLine($"{cliente} foi adicionado à fila na posição {fim + 1}");
        Console.WriteLine("=========================================");
    }
    else
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("Fila cheia");
    }
}

void AtenderCliente()
{
    if (inicio <= fim)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine($"{clientes[inicio]}, foi removido da fila!");

        for (int i = inicio; i < fim; i++)
        {
            clientes[i] = clientes[i + 1];
        }
        fim--;
        if (inicio > fim)
        {
            inicio = 0;
            fim = -1;
        }
    }

    else
    {
        Console.WriteLine("=========================================");
        Console.WriteLine("Fila vazia");
    }
}

