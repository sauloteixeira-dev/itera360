using System.CodeDom.Compiler;

string nomeTarefa, opcao;
int index;
int n;


List<string> Tarefas = new List<string>();
do
{
    Console.WriteLine("\n\nBem vindo a Lista de Tarefas\n");
    Console.WriteLine("Selecione uma opção:\n");
    Console.WriteLine("1 - Adicionar nova Tarefa\n");
    Console.WriteLine("2 - Consultar Tarefa\n");
    Console.WriteLine("3 - Remover Tarefa\n");
    Console.WriteLine("0 - Sair da Lista de Tarefas\n");
    n = Tarefas.Count;
    Console.WriteLine($"A contagem de N é: {n}");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("\nInforme a Tarefa:\n");
            nomeTarefa = Console.ReadLine();
            Tarefas.Add(nomeTarefa);
            Console.WriteLine($"\nTarefa: {nomeTarefa}, adicionada com sucesso!\n");
            break;
        case "2":
            if (n > 0)
            {
                MostrarTarefas();
            }
            else
            {
                Console.WriteLine("Lista Vazia!");
            }
            ;
            break;
        case "3":
            if (n >= 0)
            {
                MostrarTarefas();
                Console.WriteLine("\nInforme o numero da tarefa:\n");
                index = int.Parse(Console.ReadLine());
                if (index < n)
                {
                    Tarefas.RemoveAt(index);
                    Console.WriteLine("Removido com Sucesso!");
                }

            }
            else
            {
                Console.WriteLine("Lista Vazia");
            }
            break;
        default:
            opcao = "0";
            break;
    }
} while (opcao != "0");

void MostrarTarefas()
{
    int i = 0;
    Console.WriteLine("As Tarefas são: \n");
    Console.WriteLine("");
    foreach (var tar in Tarefas)
    {
        Console.WriteLine($"{i++} - {tar}\n");
    }
}

