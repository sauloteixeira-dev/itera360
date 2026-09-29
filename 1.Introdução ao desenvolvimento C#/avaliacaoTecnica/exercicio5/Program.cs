string nomeCliente, produto;
string opcao;
float valorFrete;

Console.WriteLine("Informe o nome do cliente: ");
nomeCliente = Console.ReadLine();

Console.WriteLine("Informe o nome do Produto: ");
produto = Console.ReadLine();


Console.WriteLine($"Informe para qual estado região deve ser enviado {produto}:");
Console.WriteLine("\nSudeste\nNordeste\nCentroOeste\nSul\nNorte");

opcao = Console.ReadLine().ToLower();

valorFrete = calcularFrete(opcao);


Console.WriteLine($"Olá, {nomeCliente}, valor do produto: {produto}, é de: {valorFrete:C}");


float calcularFrete(string local)
{
    float valorFrete = 0;
    if (local == "sudeste")
    {
        valorFrete = 20;
    }
    else if (local == "nordeste")
    {
        valorFrete = 30;
    }
    else if (local == "centrooeste")
    {
        valorFrete = 25;
    }
    else if (local == "sul")
    {
        valorFrete = 20;
    }
    else if (local == "norte")
    {
        valorFrete = 40;
    }
    return valorFrete;
}






