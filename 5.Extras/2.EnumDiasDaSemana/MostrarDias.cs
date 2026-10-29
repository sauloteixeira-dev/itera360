public class MostrarDias
{
    public void mostrarDias()
    {
        int i = 1;

        foreach (var dia in Enum.GetValues(typeof(DiasDaSemana)))
        {
            Console.WriteLine($"{i} - {dia}");
            i++;
        }
    }
}
