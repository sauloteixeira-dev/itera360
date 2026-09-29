string[] tarefas = new string[6];
string[] status = new string[6];
int inicio = -1;
int opcao;
string add;
string tarefaConcluida;

do
{
    Console.WriteLine("\nBem vindo ao Controle de Tarefas!\n");
    Console.WriteLine("\n\nInforme uma opção: \n1 - Adicionar Tarefa\n2 - Mostrar Tarefas\n3 - Concluir Tarefa\n0 - Sair ");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o Nome:");
            add = Console.ReadLine();

            AdicionarTarefa(add.ToUpper());
            break;
        case 2:
            MostrarTarefas();
            break;
        case 3:
            MostrarTarefas();
            Console.WriteLine("\nInforme Nome da tarefa: ");
            tarefaConcluida = Console.ReadLine();
            ConcluirTarefas(tarefaConcluida.ToUpper());
            break;
    }

} while (opcao != 0);

void AdicionarTarefa(string add)
{
    if (inicio < 5)
    {
        inicio++;

        tarefas[inicio] = add;
        status[inicio] = "PENDENTE";
        Console.WriteLine("");
        Console.WriteLine($"Adicionado:\n\nNº {inicio + 1} Tarefa: {add} Status: {status[inicio]}");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("\nLista cheia\n");
    }
}

void MostrarTarefas()
{
    if (tarefas.Length >= 5)
    {
        Console.WriteLine("\nLista:\n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"Nº: {i + 1} Tarefa: {tarefas[i]} Status: {status[i]}\n");
        }
    }
    else
    {
        Console.WriteLine("\n Sem tarefas \n");
    }
}

void ConcluirTarefas(string tarefaConcluida)
{
    bool encontrou = false;

    for (int i = 0; i <= inicio; i++)
    {
        if (tarefaConcluida == tarefas[i])
        {
            Console.WriteLine($"Atualizado status de {tarefas[i]} para CONCLUÍDO");
            encontrou = true;
            status[i] = "CONCLUÍDO";
            break;
        }
    }
    if (!encontrou)
    {
        Console.WriteLine("Tarefa não encontrada!");
    }
}




