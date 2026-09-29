//EmAçao - Agenda 

string[] agendas = new string[5];
int[] numeros = new int[5];
int opcao;
int inicio = -1;
string contato;
int numero;
string retirar;

do
{
    Console.WriteLine("================================");
    Console.WriteLine("\nBem vindo a Agenda!\n");
    Console.WriteLine("================================");
    Console.WriteLine("\nInforme a opção desejada: ");
    Console.WriteLine("1 - Adicionar novo Contato\n2 - Remover Contato pelo NOME\n3 - Listar Contatos\n0 - Sair\n\n");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("Informe o Nome do Contato: \n");
        contato = Console.ReadLine().ToUpper();
        Console.WriteLine("Informe o Número do contato:\n");
        numero = int.Parse(Console.ReadLine());
        AdicionarNovoContato(contato, numero);
    }
    else if (opcao == 2)
    {
        if (inicio >= 0)
        {
            MostrarNomesDaAgenda();
            Console.WriteLine("\nInforme um NOME para retirar:\n");
            retirar = Console.ReadLine();
            RemoverContatosPeloNome(retirar);
        }
        else
        {
            Console.WriteLine("Não há contatos na lista");
        }
    }
    else if (opcao == 3)
    {
        MostrarNomesDaAgenda();
    }


} while (opcao != 0);

void AdicionarNovoContato(string contato, int num)
{
    if (inicio < 4)
    {
        inicio++;
        agendas[inicio] = contato.ToUpper();
        numeros[inicio] = num;

        Console.WriteLine($"\nAdicionado:\nNome: {contato} Numero: {num}");
    }
    else
    {
        Console.WriteLine("\nAgenda cheia!");
    }
}

void MostrarNomesDaAgenda()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nContato:");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"\nNº:{i + 1} Nome: {agendas[i]}, Tel: {numeros[i]}");
        }
    }
    else
    {
        Console.WriteLine("A lista está vazia!");
    }
}

void RemoverContatosPeloNome(string retirar)
{
    string nome = retirar.ToUpper();

    bool encontrou = false;

    for (int i = 0; i <= inicio; i++)
    {
        if (agendas[i] == nome)
        {
            Console.WriteLine($"\nNome: {agendas[i]} Tel:{numeros[i]}, foram removidos\n");
            for (int j = i; j < inicio; j++)
            {
                agendas[j] = agendas[j + 1];
                numeros[j] = numeros[j + 1];
            }
            agendas[inicio] = "";
            numeros[inicio] = 0;

            inicio--;
            encontrou = true;
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("Contato não encontrado");
    }
}

