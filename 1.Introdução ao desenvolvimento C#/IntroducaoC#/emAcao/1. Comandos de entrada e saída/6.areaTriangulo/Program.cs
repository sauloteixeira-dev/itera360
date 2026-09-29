double largura;
double altura;
double calculoArea;

Console.WriteLine("Informe a largura do triângulo: ");
largura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a altura do triângulo: ");
altura = double.Parse(Console.ReadLine());

calculoArea = (largura * altura) / 2;

Console.WriteLine($"A área do triângulo é : {calculoArea.ToString("f")}");