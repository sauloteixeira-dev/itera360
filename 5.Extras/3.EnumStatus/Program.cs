public class Program
{
    private static void Main(string[] args)
    {
        int nStatus;
        bool validador = false;
        var show = new MostrarStatus();

        do
        {
            Console.WriteLine("Informe uma opção:");
            show.mostrarStatus();

            try
            {

                if (int.TryParse(Console.ReadLine(), out nStatus) && Enum.IsDefined(typeof(Status), nStatus))
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1, 2, 3 ou 4");
                }

                switch ((Status)nStatus)
                {
                    case Status.Pendente:
                        Console.WriteLine($"Status atual: {Status.Pendente}");
                        break;
                    case Status.EmAndamento:
                        Console.WriteLine($"Status atual: {Status.EmAndamento}");
                        break;
                    case Status.Concluido:
                        Console.WriteLine($"Status atual: {Status.Concluido}");
                        break;
                    case Status.Cancelado:
                        Console.WriteLine($"Status atual: {Status.Cancelado}");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }

        } while (validador == false);
    }
}
/*
Enum de Status
Crie um enum chamado Status com os valores: Pendente, EmAndamento, Concluido e Cancelado.
O programa deve:
10.	Pedir ao usuário um número de 1 a 4 para definir um status.
11.	Usar um switch para exibir uma mensagem personalizada para cada status (ex: "O arquivo está pendente.", "O arquivo foi concluído com sucesso.").
12.	Caso o número não corresponda a nenhum status, exibir uma mensagem de erro.
13.	Listar todos os status do enum utilizando um foreach com Enum.GetValues.
*/