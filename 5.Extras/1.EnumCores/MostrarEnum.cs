public class MostrarEnum
{
    public void mostrarEnum()
    {
        int i = 1;

        foreach (var cor in Enum.GetValues(typeof(Cores)))
        {
            Console.WriteLine($"{i} - {cor}");
            i++;
        }
    }
}

