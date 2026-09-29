double raio, resposta;


Console.WriteLine("Informe o raio do circulo: ");
raio = double.Parse(Console.ReadLine());

double areaCirculo(double raio)
{
    double pi = 3.14;
    double area;

    area = pi * (raio * raio);

    return area;
}
resposta = areaCirculo(raio);

Console.WriteLine($"O valor da área é: {resposta}");




