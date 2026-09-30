//array vetor
int nVetor = 10; 

string[] produtos = new string[nVetor];
double[] precos = new double[nVetor];
double[] qtds = new double[nVetor];


// Histórico das vendas
double[] vendas = new double[100];
string[] produtosVendidos = new string[100];

int inicio = -1;

string nomeProduto;
double valor;
double quantidade;
double QtdVenda;
int opcao;

// Quantidade REAL de vendas realizadas
int qtdVendasDoDia = 0;

do
{
    Console.WriteLine("\nBem vindo a Padaria!\n\nInforme uma opção:\n1 - Adicionar produtos\n2 - Vender\n3 - Mostrar produtos\n4 - Mostrar Calculos\n\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {

        // 1 - ADICIONAR PRODUTO
        case 1:

            Console.WriteLine("\nInforme o NOME do produto:");
            nomeProduto = Console.ReadLine();

            Console.WriteLine("\nInforme o VALOR do produto:");
            valor = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme a QUANTIDADE:");
            quantidade = double.Parse(Console.ReadLine());

            AdicionarProdutosAndPrecos(nomeProduto, valor, quantidade);
            break;

        // 2 - VENDER
        case 2:
            MostrarEstoque();

            Console.WriteLine("Informe qual NOME do produto:");
            nomeProduto = Console.ReadLine();

            Console.WriteLine("Informe a QUANTIDADE a vender:");
            QtdVenda = double.Parse(Console.ReadLine());

            Vender(nomeProduto, QtdVenda);

            break;
        // 3 - MOSTRAR ESTOQUE
        case 3:

            MostrarEstoque();
            break;

        // 4 - MOSTRAR CÁLCULOS
        case 4:
            mostrarNumeroMaiorEMenor(qtdVendasDoDia);
            break;

        // 0 - SAIR
        case 0:
            Console.WriteLine("\nSaindo do sistema...");
            break;
        default:
            Console.WriteLine("\nOpção inválida!");
            break;
    }

} while (opcao != 0);




// 1 - ADICIONAR PRODUTO


void AdicionarProdutosAndPrecos(string product, double price, double qtd)
{
    if (inicio < 9)
    {
        if (qtd <= 0 || price <= 0)
        {
            Console.WriteLine("\nValor ou quantidade inválida.\n");
            return;
        }

        inicio++;

        produtos[inicio] = product.ToUpper();
        precos[inicio] = price;
        qtds[inicio] = qtd;

        Console.WriteLine("");
        Console.WriteLine($"Adicionado:\n\nProduto: {produtos[inicio]}\nPreço: {precos[inicio]:C}\nEstoque: {qtds[inicio]}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("\nLista de produtos cheia!\n");
    }
}




// 2 - VENDER
void Vender(string NomProduto, double QtdVenda)
{
    string nome = NomProduto.ToUpper();
    bool encontrou = false;

    if (QtdVenda <= 0)
    {
        Console.WriteLine("\nQuantidade inválida.\n");
        encontrou = false;
    }

    for (int i = 0; i <= inicio; i++)
    {
        if (produtos[i] == nome)
        {
            // Verifica estoque
            if (qtds[i] < QtdVenda)
            {
                Console.WriteLine(
                    $"\nProduto {produtos[i]} sem estoque suficiente.\n" +
                    $"Estoque disponível: {qtds[i]}\n"
                );
                encontrou = false;
            }
            else
            {
                qtds[i] -= QtdVenda;

                double valorDaVenda = QtdVenda * precos[i];

                vendas[qtdVendasDoDia] = valorDaVenda;
                produtosVendidos[qtdVendasDoDia] = produtos[i];

                qtdVendasDoDia++;

                Console.WriteLine($"\nVendido:\nProduto: {produtos[i]}\nQuantidade: {QtdVenda}\nValor da venda: {valorDaVenda:C}\n");

                Console.WriteLine($"Atualizado:\nProduto: {produtos[i]}\nEstoque atual: {qtds[i]}\n");

                encontrou = true;
            }
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("\nTente novamente\n");
    }

}

// 3 - MAIOR, MENOR, TOTAL E MÉDIA
void mostrarNumeroMaiorEMenor(int qtdVendasDoDia)
{
    if (qtdVendasDoDia <= 0)
    {
        Console.WriteLine("\nNão existem vendas cadastradas.\n");

        return;
    }

    double eMaior = vendas[0];
    double eMenor = vendas[0];
    string produtoMaior = produtosVendidos[0];
    string produtoMenor = produtosVendidos[0];
    double vendasTotal = 0;
    int indiceMaior = 0;
    int indiceMenor = 0;

    for (int i = 0; i < qtdVendasDoDia; i++)
    {
        // Soma todas as vendas
        vendasTotal += vendas[i];

        if (vendas[i] > eMaior)
        {
            eMaior = vendas[i];

            indiceMaior = i;
        }

        if (vendas[i] < eMenor)
        {
            eMenor = vendas[i];

            indiceMenor = i;
        }
    }

    // NOMES DOS PRODUTOS
    produtoMaior = produtosVendidos[indiceMaior];
    produtoMenor = produtosVendidos[indiceMenor];


    // DIFERENÇA ENTRE MAIOR E MENOR
    double diferencaVendas = eMaior - eMenor;

    // MÉDIA ENTRE MAIOR E MENOR
    double valorMedio = (eMaior + eMenor) / 2;

    // TICKET MÉDIO
    double mediaVendas = vendasTotal / qtdVendasDoDia;

    // RELATÓRIO
    Console.WriteLine("\n##======== Relatório Diário ========##\n");
    Console.WriteLine($"A Maior Venda é de: {produtoMaior} | Total: {eMaior:C}");
    Console.WriteLine("");
    Console.WriteLine($"A Menor Venda é de: {produtoMenor} | Total: {eMenor:C}");
    Console.WriteLine("");
    Console.WriteLine($"O valor médio entre a maior e menor venda é: {valorMedio:C}");
    Console.WriteLine("");
    Console.WriteLine($"O tiket médio é: {mediaVendas:C}");
    Console.WriteLine("");
    Console.WriteLine($"A diferença entre a maior venda {eMaior:C} e a menor venda {eMenor:C} é: {diferencaVendas:C}");
    Console.WriteLine("");
    Console.WriteLine($"Total de Vendas do dia: {qtdVendasDoDia} , Totalizando {vendasTotal:C}");
    Console.WriteLine("");

}

// 4 - MOSTRAR ESTOQUE
void MostrarEstoque()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nProdutos no sistema:\n");

        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"Nº: {i + 1} Produto: {produtos[i]} | Estoque: {qtds[i]} | Preço: {precos[i]:C}");
            Console.WriteLine("");
        }
    }
    else
    {
        Console.WriteLine("\nA lista está vazia.\n");
    }
}
