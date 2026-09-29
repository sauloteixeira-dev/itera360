double preco;
double desconto;
double calculoDesconto;
double resultado;


Console.WriteLine("Informe um preço: ");
preco = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor de desconto: (se 20% informe 20)");
desconto = double.Parse(Console.ReadLine());

calculoDesconto = preco * (desconto / 100);
resultado = preco - calculoDesconto;

Console.WriteLine($"O valor final do produto com desconto é: {resultado.ToString("f")}");