double largura;
double altura;
double calculoArea;

Console.WriteLine("Informe a largura do retângulo: ");
largura = double.Parse(Console.ReadLine());

Console.WriteLine("Informe a altura do retângulo: ");
altura = double.Parse(Console.ReadLine());

calculoArea = largura * altura;

Console.WriteLine($"A área do retângulo é : {calculoArea.ToString("f")}");