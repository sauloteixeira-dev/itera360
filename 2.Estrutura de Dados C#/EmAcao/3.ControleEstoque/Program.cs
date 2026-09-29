string[] produtos = new string[5];
int[] qtds = new int[5];
int inicio = -1;
int opcao;
string produto;
int qtd;
string removerProduto;
do
{
    Console.WriteLine("\nInforme qual opção deseja:\n1 - Adicionar Produtos ao estoque\n2 - Remover Produto pelo Nome\n3 - Mostrar Produtos na Lista\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("\nInforme o nome do Produto: ");
        produto = Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("\nInforme a quantidade: ");
        qtd = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        AdicionarNovoProduto(produto, qtd);
    }
    else if (opcao == 2)
    {
        MostrarProdutos();
        Console.WriteLine("Informe qual produto deseja remover:");
        removerProduto = Console.ReadLine();
        RemoverProdutosPorNome(removerProduto);
    }
    else if (opcao == 3)
    {
        MostrarProdutos();
    }
} while (opcao != 0);

void AdicionarNovoProduto(string produto, int qtd)
{
    if (inicio < 4)
    {
        inicio++;
        produtos[inicio] = produto.ToUpper();
        qtds[inicio] = qtd;
        Console.WriteLine($"\nProduto: {produto.ToUpper()} - {qtd} na posição {inicio + 1}\n"); //se colocar string no lugar do numero irá quebrar;
    }
    else
    {
        Console.WriteLine("\nLista cheia\n");
    }
}

void MostrarProdutos()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nProdutos no sistema:\n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"\nNº: {i + 1} Produto: {produtos[i]} - {qtds[i]}\n");
        }
    }
    else
    {
        Console.WriteLine("\nA lista está vazia\n");
    }
}

void RemoverProdutosPorNome(string NomProduto)
{
    string nome = NomProduto.ToUpper();

    bool encontrou = false;

    for (int i = 0; i <= inicio; i++)
    {
        if (produtos[i] == nome)
        {
            Console.WriteLine($"Nº: {i + 1} Produto: {nome} Qtd: {qtds[i]} , foi removido da lista");

            for (int j = i; j < inicio; j++)
            {
                produtos[j] = produtos[j + 1];
                qtds[j] = qtds[j + 1];
            }
            produtos[inicio] = "";
            qtds[inicio] = 0;

            inicio--;
            encontrou = true;
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("Opção inválida, tente novamente");
    }
}

