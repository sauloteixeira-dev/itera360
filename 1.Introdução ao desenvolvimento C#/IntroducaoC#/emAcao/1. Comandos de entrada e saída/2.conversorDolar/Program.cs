double real;
double conversao;

Console.WriteLine("Informe um valor para a conversão: \n");
real = double.Parse(Console.ReadLine());


conversao = real * 5.10;

Console.WriteLine($"\nO valor de  R${real.ToString("f")}, convertido para Dólar é de: USD${conversao.ToString("f")}\n");