string[] tarefas = new string[5];
int opcao;
string task;
int inicio = 0, fim = -1;

do
{
    Console.WriteLine("Informe uma opção: \n1 - Adicionar nova tarefa\n2 - Tarefa Concluída\n3 - Mostrar tarefas\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        Console.WriteLine("\nInforme a tarefa: ");
        task = Console.ReadLine();
        NovaTarefa(task);
    }
    else if (opcao == 2)
    {
        TarefaConcluida();
    }
    else if (opcao == 3)
    {
        MostrarTarefas();
    }

} while (opcao != 0);




void NovaTarefa(string nomeTarefa)
{
    //se o fim tiver espaço na lista de 5 posições.. vai adicionar, se não = está cheio
    if (fim < 4)
    {
        fim++;
        tarefas[fim] = nomeTarefa;
        Console.WriteLine("=========================================");
        Console.WriteLine($"\n{nomeTarefa} foi adicionado à fila na posição {fim + 1}\n");
        Console.WriteLine("=========================================");
    }
    else
    {
        Console.WriteLine("\n\nCheio de tarefas!!\n\n");
    }
}

void TarefaConcluida()
{   //
    if (inicio <= fim)
    {
        Console.WriteLine("=========================================");
        Console.WriteLine($"{tarefas[inicio]}, foi removido da lista de tarefas!");

        for (int i = inicio; i < fim; i++)
        {
            tarefas[i] = tarefas[i + 1];
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
        Console.WriteLine("Lista vazia!\n");
    }
}

void MostrarTarefas()
{
    if (fim >= 0)
    {
        for (int i = 0; i <= fim; i++)
        {
            Console.WriteLine("=========================================");
            Console.WriteLine($"\nNº:{i + 1} Tarefa: {tarefas[i]}\n");
            Console.WriteLine("=========================================");

        }
    }
    else
    {
        Console.WriteLine("\nA lista está vazia!\n");
    }
}