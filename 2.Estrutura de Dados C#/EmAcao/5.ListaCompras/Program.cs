string[] listaCompras = new string[5];
int opcao;
int inicio = -1;
string item, removerItem;

do
{
    Console.WriteLine("Bem Vindo a lista de compras!\n");
    Console.WriteLine("\nEscolha uma opção:\n\n1 - Adicionar item\n2 - Remover item\n3 - Mostrar itens\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("Informe o nome do item: ");
        item = Console.ReadLine();
        AdicionarItem(item.ToUpper());
    }
    else if (opcao == 2)
    {
        MostrarItens();
        Console.WriteLine("Informe o nome do item que quer remover: ");
        removerItem = Console.ReadLine();
        RemoverItemPorNome(removerItem);
    }
    else if (opcao == 3)
    {
        MostrarItens();
    }
} while (opcao != 0);


void AdicionarItem(string item)
{
    if (inicio < 4)
    {
        inicio++;

        listaCompras[inicio] = item;

        Console.WriteLine($"\nAdicionando: \nNº {inicio + 1} Item {item}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("\n Lista cheia\n");
    }
}

void RemoverItemPorNome(string removerItem)
{
    string nomeItem = removerItem.ToUpper();

    bool encontrou = false;

    for (int i = 0; i <= inicio; i++)
    {
        if (nomeItem == listaCompras[i])
        {
            Console.WriteLine($"Removendo {listaCompras[i]}");

            for (int j = i; j < inicio; j++)
            {
                listaCompras[j] = listaCompras[j + 1];
            }
            listaCompras[inicio] = "";

            inicio--;

            encontrou = true;
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("\nItem não encontrado!\n");
    }
}

void MostrarItens()
{
    if (listaCompras.Length >= 4)
    {
        Console.WriteLine("\nItens na Lista: \n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"Nº: {i + 1}: Item: {listaCompras[i]}\n");
        }
    }
    else
    {
        Console.WriteLine("\n Lista Vazia\n");
    }
}


