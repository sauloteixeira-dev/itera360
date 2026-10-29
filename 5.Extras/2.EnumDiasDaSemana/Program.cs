using System.Diagnostics;
public class Program
{
    private static void Main(string[] args)
    {
        int nDia;
        bool validador = false;
        var show = new MostrarDias();

        do
        {
            Console.WriteLine("Escolha uma opção: ");
            show.mostrarDias();

            try
            {
                if (int.TryParse(Console.ReadLine(), out nDia) && Enum.IsDefined(typeof(DiasDaSemana), nDia))
                {
                    validador = true;
                }
                else
                {
                    Console.WriteLine("\nValor Inexistente!\n");
                }

                switch ((DiasDaSemana)nDia)
                {
                    case DiasDaSemana.Domingo:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Domingo}");
                        break;
                    case DiasDaSemana.Segunda:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Segunda}");
                        break;
                    case DiasDaSemana.Terca:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Terca}");
                        break;
                    case DiasDaSemana.Quarta:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Quarta}");
                        break;
                    case DiasDaSemana.Quinta:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Quinta}");
                        break;
                    case DiasDaSemana.Sexta:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Sexta}");
                        break;
                    case DiasDaSemana.Sabado:
                        Console.WriteLine($"Dia escolhido: {DiasDaSemana.Sabado}");
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

/*Enum de Dias da Semana
Crie um enum chamado DiasDaSemana com os valores: os dias de Segunda-feira a Domingo.
O programa deve:
5.	Pedir ao usuário um número correspondente a um dia da semana.
6.	Validar se o número corresponde a um dia válido, usando Enum.IsDefined.
7.	Se for válido, informar se o dia é dia útil ou final de semana (Sábado e Domingo).
8.	Se for inválido, exibir uma mensagem informando que o número não corresponde a nenhum dia.
9.	Listar todos os dias da semana utilizando um foreach com Enum.GetValues.
*/