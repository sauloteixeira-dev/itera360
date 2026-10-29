public class MostrarStatus
{
    public void mostrarStatus()
    {
        int i = 1;

        foreach (var status in Enum.GetValues(typeof(Status)))
        {
            Console.WriteLine($"{i} - {status}");
            i++;
        }
    }
}