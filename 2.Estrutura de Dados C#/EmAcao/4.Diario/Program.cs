string[] aulas = new string[5];
int inicio = -1;
int opcao;
string aula;
string retirar;

do
{
    Console.WriteLine("\n\nInforme a opção desejada:\n1 - Adicionar Nova Aula\n2 - Remover Aula\n3 - Mostrar Aulas\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());
    Console.WriteLine("");
    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nInforme o NOME da aula: ");
            aula = Console.ReadLine();
            Console.WriteLine("");
            AdicionarNovaAula(aula.ToUpper());
            break;
        case 2:
            MostrarAulas();
            Console.WriteLine("\nInforme o NOME da aula que deseja remover: ");
            retirar = Console.ReadLine();
            RemoverAulaPorNome(retirar);
            break;
        case 3:
            MostrarAulas();
            break;
    }

} while (opcao != 0);



void AdicionarNovaAula(string aula)
{
    if (inicio < 4)
    {
        inicio++;
        aulas[inicio] = aula.ToUpper();

        Console.WriteLine($"\nAula {aula}, Foi adicionada na posição {inicio + 1}\n");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("\nLista de Aulas cheia\n");
        Console.WriteLine("");
    }
}

void RemoverAulaPorNome(string retirar)
{
    string nomeAula = retirar.ToUpper();

    bool encontrou = false;


    for (int i = 0; i <= inicio; i++)
    {
        if (nomeAula == aulas[i])
        {
            Console.WriteLine($"\nRemovendo: {aulas[i]}, da posição nº:{i + 1}");
            Console.WriteLine($"Aula: {aulas[i]} removida com sucesso!\n\n");

            for (int j = i; j < inicio; j++)
            {
                aulas[j] = aulas[j + 1];
            }

            aulas[inicio] = "";

            inicio--;
            encontrou = true;

            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("\nOpção inválida!");
    }
}

void MostrarAulas()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nAulas no sistema:\n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"\n{i + 1}ª: {aulas[i]}\n");
        }
    }
    else
    {
        Console.WriteLine("\nA lista está vazia\n");
    }
}
