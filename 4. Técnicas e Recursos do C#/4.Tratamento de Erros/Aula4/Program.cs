internal class Program
{
    private static void Main(string[] args)
    {
        // Carro carroVelho = null;

        // carroVelho.Acelerar();

        //com erro antes do tryCatch
        /*dotnet run
        Unhandled exception. System.NullReferenceException: Object reference not set to an instance of an object.
        at Program.Main(String[] args) in C:\Alunos\SauloTeixeira\4. Técnicas e Recursos do C#\4.Tratamento de Erros\Aula4\Program.cs:line 7*/

        try
        {
            Carro carroVelho = null;

            carroVelho.Acelerar();
        }
        catch (Exception ex)
        {
            // Console.WriteLine(ex.Message);
            Console.WriteLine("Ocorreu um erro inesperado! Procure o suporte!");
        }
        finally
        {
            Console.WriteLine("Fim");
        }

        // }
        //sem erros dessa forma:
        /*dotnet run
            Ocorreu um erro inesperado! Procure o suporte!
        Fim */
    }

}