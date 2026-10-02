
//inicio dos array's
int[] tags = new int[10];
double[] saldos = new double[10];

//variaveis
int numtag, addTag;
double valorInserido;

int inicio = -1;

int valorPedagio = 20;

int opcao;


do
{
    Console.WriteLine("\n\n=========  Bem vindo ao sistema de pedagios por TAGS  =========\n\n");
    Console.WriteLine("Selecione uma opção:\n");
    Console.WriteLine("1 - Adicionar TAG\n2 - Carregar Saldo\n3 - Registrar passagem\n\n0 - Sair\n\n");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("\n\nInforme um numero de tag: ");
            addTag = int.Parse(Console.ReadLine());
            AdicionarTag(addTag);

            break;
        case 2:
            Console.WriteLine("\nInforme sua Tag:");
            numtag = int.Parse(Console.ReadLine());

            Console.WriteLine("\nInforme o valor a ser carregado:");
            valorInserido = double.Parse(Console.ReadLine());

            CarregarSaldo(numtag, valorInserido);

            break;
        case 3:
            Console.WriteLine("Informe sua Tag:");
            numtag = int.Parse(Console.ReadLine());

            PassagemPedagio(numtag, valorPedagio);
            break;

        case 0:
            Console.WriteLine("Saindo do sistema...");
            break;

    }
} while (opcao != 0);



//1
void AdicionarTag(int addTag)
{
    inicio++;

    if (inicio >= 0 && inicio <= tags.Length)
    {
        tags[inicio] = addTag;
        saldos[inicio] = 0;
    }

    Console.WriteLine($"Tag: {tags[inicio]} adicionada na posição Nº{inicio + 1}");
}

//2
void CarregarSaldo(int num, double valor)
{
    bool encontrou = false;

    for (int i = 0; i < tags.Length; i++)
    {
        if (num == tags[i])
        {
            Console.WriteLine($"\n\nTag Encontrada: {num} \n\n");

            saldos[inicio] += valor;

            encontrou = true;
            Console.WriteLine($"Valor: {valor:C} adicionado a {num}");
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine($"Tag: {num} Não existe / Não encontrado");
    }
}

//3
void PassagemPedagio(int tag, int preco)
{
    bool encontrou = false;

    for (int i = 0; i <= tags.Length; i++)
    {
        if (tag == tags[i])
        {
            if (saldos[i] >= preco)
            {
                saldos[i] -= preco;
                Console.WriteLine($"A Tag: {tag} passou pelo pedágio. Saldo restante: {saldos[i]:C}");
                encontrou = true;
                break;
            }
            else if (saldos[i] < preco)
            {
                Console.WriteLine($"Saldo insuficiente para a Tag: {tags[i]} Saldo: {saldos[i]:C}");
                encontrou = true;
                break;
            }
        }
        else
        {
            Console.WriteLine($"Tag: {tag}, não encontrada!");
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine($"Não existe a tag {tag} no sistema");
    }
}