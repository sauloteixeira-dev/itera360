using System.Diagnostics;

public class Program
{
    private static void Main(string[] args)
    {
        int nCor;
        bool validador = false;
        var show = new MostrarEnum();

        do
        {
            Console.WriteLine("Informe uma opção:");
            show.mostrarEnum();

            try
            {
                if (int.TryParse(Console.ReadLine(), out nCor) && Enum.IsDefined(typeof(Cores), nCor))
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("Erro: Valor não existe! Digite 1,2 ou 3");
                }

                switch ((Cores)nCor)
                {
                    case Cores.Vermelho:
                        Console.WriteLine($"Cor escolhida: {Cores.Vermelho}");
                        break;
                    case Cores.Verde:
                        Console.WriteLine($"Cor escolhida: {Cores.Verde}");
                        break;
                    case Cores.Azul:
                        Console.WriteLine($"Cor escolhida: {Cores.Azul}");
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
Enum de Cores
Crie um enum chamado Cores com os valores: Vermelho, Verde e Azul.
O programa deve:
1.	Pedir ao usuário um número correspondente a uma cor.
2.	Usar um switch para exibir o nome da cor correspondente.
3.	Caso o número não corresponda a nenhuma cor, exibir uma mensagem informando que a cor é inexistente.
4.	Listar todas as cores do enum utilizando um foreach com Enum.GetValues.
*/