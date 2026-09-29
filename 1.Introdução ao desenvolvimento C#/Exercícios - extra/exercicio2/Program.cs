string nome;
int idade;
double valorTotal, desconto;


Console.WriteLine("Informe seu nome: \n");
nome = Console.ReadLine();

Console.WriteLine("Informe sua Idade: \n");
idade = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor Total:  \n");
valorTotal = double.Parse(Console.ReadLine());



if (idade >= 70)
{
    desconto = valorTotal * 0.50;
    Console.WriteLine($"Seu desconto é de: {desconto:C} e o valor é de: {valorTotal - desconto:C}");
}
else if (idade >= 60)
{
    desconto = valorTotal * 0.40;
    Console.WriteLine($"Seu desconto é de: {desconto:C} e o valor é de: {valorTotal - desconto:C}");
}
else if (idade >= 50)
{
    desconto = valorTotal * 0.30;
    Console.WriteLine($"Seu desconto é de: {desconto:C} e o valor é de: {valorTotal - desconto:C}");
}
else if (idade >= 40)
{
    desconto = valorTotal * 0.20;
    Console.WriteLine($"Seu desconto é de: {desconto:C} e o valor é de: {valorTotal - desconto:C}");
}
else if (idade >= 30)
{
    desconto = valorTotal * 0.10;
    Console.WriteLine($"Seu desconto é de: {desconto:C} e o valor é de: {valorTotal - desconto:C}");
}
else
{
    Console.WriteLine($"Infelizmente vc não obteve desconto... o valor é : {valorTotal:C}");
}


