double preco, aVista;
int escolha;

Console.WriteLine("Informe o preço do produto: ");
preco = float.Parse(Console.ReadLine());

Console.WriteLine("O pagamento será \n1 - A VISTA (com 10% de desconto) \n2 - A PRAZO");
escolha = int.Parse(Console.ReadLine());

if (escolha == 1)
{
    aVista = preco - (preco * 0.1);
    Console.WriteLine($"O valor final é R${aVista.ToString("f")} ");
}
else
{
    Console.WriteLine($"O valor final é R${preco.ToString("f")} ");
}
