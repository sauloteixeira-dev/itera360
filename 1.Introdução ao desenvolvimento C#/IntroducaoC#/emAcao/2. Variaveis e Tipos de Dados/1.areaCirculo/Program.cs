double area, raio, pi;

pi = 3.14;

Console.WriteLine("Informe o raio de um circulo para o cálculo: (Ex: 8,0) ");
raio = float.Parse(Console.ReadLine());

area = pi *(raio * raio);
double valorInt = (double)area;

Console.WriteLine($"A área do círculo é de: {valorInt.ToString("f")}");