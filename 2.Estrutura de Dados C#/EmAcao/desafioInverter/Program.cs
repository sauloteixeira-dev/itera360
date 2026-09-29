int[] numeros = [10, 15, 2354, 14, 18, 35, 1, 8, 13, 63];

mostrar();

void mostrar()
{
    int n = 0;
    for (int i = 0; i <= 4; i++)
    {
        n = numeros[i];

        numeros[i] = numeros[i + 5];

        Console.WriteLine($"{numeros[i]}, {numeros[n]}");
    }

}









