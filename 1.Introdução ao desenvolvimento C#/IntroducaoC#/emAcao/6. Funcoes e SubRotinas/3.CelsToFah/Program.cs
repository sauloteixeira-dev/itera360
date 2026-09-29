double celsius, fahr, resultado;

Console.WriteLine("Informe um valor em Celsius: ");
celsius = double.Parse(Console.ReadLine());

resultado = CelsiusParaFahrenheit(celsius);

Console.WriteLine($"O valor de {celsius}ºC em Fahrenheit é: {resultado}ºF");

double CelsiusParaFahrenheit(double celsius)
{
    fahr = (celsius * 1.8) + 32;
    return fahr;
}

