
string[] tarefas = new string[5];
string task;
int opcao;
int i = 0;

do
{
    Console.WriteLine("Informe a opção: \n1 - Adicionar nova tarefa\n2 - Remover ultima tarefa\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)

    {

        case 1:
            Console.WriteLine("\n================================");
            Console.WriteLine("\nInforme a tarefa: ");
            task = Console.ReadLine();
            Push(task);
            break;

        case 2:
            Pop();
            break;
    }

} while (opcao != 0);

void Push(string tarefa)
{
    if (i < 5)
    {
        tarefas[i] = tarefa;
        Console.WriteLine("\n================================");
        Console.WriteLine(tarefa + " - Foi adicionado a pilha\n");
        Console.WriteLine("\n================================");
        Console.WriteLine("A tarefa que precisa ser resolvida agora é: " + tarefas[i]);
        i++;
    }
    else
    {
        Console.WriteLine("\n================================");
        Console.WriteLine("A pilha está cheia.\n");
        Console.WriteLine("\n================================");
    }
}

void Pop()
{
    if (i > 0)
    {
        i--;
        Console.WriteLine("\n================================");
        Console.WriteLine(tarefas[i] + " Foi removido\n");
        Console.WriteLine("\n================================");

        tarefas[i] = string.Empty;

    }
    else
    {
        Console.WriteLine("\n================================");
        Console.WriteLine("A pilha está vazia.\n");
        Console.WriteLine("\n================================");
    }
}


























