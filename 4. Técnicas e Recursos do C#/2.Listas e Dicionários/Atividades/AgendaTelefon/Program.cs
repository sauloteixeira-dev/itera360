using Microsoft.VisualBasic;

string nome, telefone, opcao;

//Instanciada a Agenda

Dictionary<string, string> Agenda = new Dictionary<string, string>();

do
{
    Console.WriteLine("Bem vindo a Agenda telefonica:");
    Console.WriteLine("Selecione uma opção:");
    Console.WriteLine("1 - Adicionar novo contato");
    Console.WriteLine("2 - Consultar contato");
    Console.WriteLine("3 - Remover contato");
    Console.WriteLine("0 - Sair da agenda");
    opcao = Console.ReadLine();
    switch (opcao)
    {
        case "1":
            Console.WriteLine("Informe o Nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Informe o Telefone:");
            telefone = Console.ReadLine();
            Agenda.Add(nome, telefone);
            break;
        case "2":
            Console.WriteLine("Informe o Nome:");
            nome = Console.ReadLine();
            if (Agenda.ContainsKey(nome))
            {
                Console.WriteLine($"Nome:{Agenda[nome]}");
            }
            else
            {
                Console.WriteLine("Não encontrado!");
            }
            break;
        case "3":
            Console.WriteLine("Informe o Nome:");
            nome = Console.ReadLine();

            if (Agenda.ContainsKey(nome) == true)
            {
                Console.WriteLine($"Removido contato: {nome}");
                Agenda.Remove(nome);
            }
            else
            {
                Console.WriteLine("Contato não encontrado!");
            }
            break;
        case "0":
            opcao = "0";
            break;

        default:
            Console.WriteLine("Informe uma opcao Válida!");
            break;
    }

} while (opcao != "0");



