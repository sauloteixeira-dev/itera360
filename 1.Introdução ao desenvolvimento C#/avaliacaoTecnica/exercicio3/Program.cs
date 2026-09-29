string nome, cidade;

Console.WriteLine("Informe seu nome:");
nome = Console.ReadLine();

Console.WriteLine("Informe sua cidade:");
cidade = Console.ReadLine();


for (int i = 1; i <= 100; i++)
{
    if (i == 1)
    {
        Console.WriteLine($"Produção começando... {i}% {nome}");
    }
    else if (i == 25)
    {
        Console.WriteLine($"Estamos a {i}% do seu pedido! {nome} Aproveite um café enquanto espera em {cidade}");
    }
    else if (i == 50)
    {
        Console.WriteLine($"Estamos a {i}% do seu pedido! {nome} Aproveite a vista maravilhosa de {cidade}");
    }
    else if (i == 75)
    {
        Console.WriteLine($"Estamos a {i}% do seu pedido! {nome} Que tal um lanche enquanto espera em {cidade}");
    }
    else if (i == 90)
    {
        Console.WriteLine($"Estamos a {i}% {nome}! Falta só um pouquinho...");
    }
    else if (i == 100)
    {
        Console.WriteLine($"Obrigado por esperar {nome}, Seu pedido foi concluído com sucesso! {i}% Volte sempre!");
    }
}