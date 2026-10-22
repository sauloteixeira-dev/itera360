string nomeTarefa, opcao;
int index;
List<string> Tarefas = new List<string>();
do
{


    Console.WriteLine("Bem vindo a Lista de Tarefas\n");
    Console.WriteLine("Selecione uma opção:\n");
    Console.WriteLine("1 - Adicionar nova Tarefa\n");
    Console.WriteLine("2 - Consultar Tarefa\n");
    Console.WriteLine("3 - Remover Tarefa\n");
    Console.WriteLine("0 - Sair da Lista de Tarefas\n");
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
            Console.WriteLine("As Tarefas são: \n");
            foreach (var nome in Tarefas)
            {
                Console.WriteLine(nome);
            }
            break;
        case "3": //TRATAR PARA O USUÁRIO DIGITAR APENAS OS INDICES QUE TEM 
            Console.WriteLine("As Tarefas são: \n");
            int i = 0;
            foreach (var tar in Tarefas)
            {
                Console.WriteLine($"{i++} - {tar}");
            }
            Console.WriteLine("\nInforme o numero da tarefa:\n");
            index = int.Parse(Console.ReadLine());
            Tarefas.RemoveAt(index);
            Console.WriteLine("Removido com Sucesso!");
            break;

        default:
            opcao = "0";
            break;
    }
} while (opcao != "0");