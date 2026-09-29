float[] temperaturas = new float[7];
string[] dias = ["Dom", "Seg", "Ter", "Qua", "Qui", "Sex", "Sáb"];
int opcao;
int inicio = -1;
float temperatura;

do
{
    Console.WriteLine("");
    Console.WriteLine("Escolha uma opção:\n\n1 - Inserir temperatura\n2 - Calcular média\n3 - Exibir temperaturas da semana\n4 - Exibir temperatura Maior e Menor da semana\n\n0 - Sair");
    Console.WriteLine("");
    opcao = int.Parse(Console.ReadLine());
    switch (opcao)
    {
        case 1:
            Console.WriteLine("\nInforme a temperatura: ");
            Console.WriteLine("");
            temperatura = float.Parse(Console.ReadLine());
            AdicionarTemperatura(temperatura);
            break;
        case 2:
            Console.WriteLine("Calculando média...");
            CalcularMédia();
            break;
        case 3:
            MostrarDados();
            break;
        case 4:
            mostrarNumeroMaiorEMenor();
            break;

    }
} while (opcao != 0);

void AdicionarTemperatura(float temp)
{
    if (inicio < 6)
    {
        inicio++;
        temperaturas[inicio] = temp;
        Console.WriteLine("");
        Console.WriteLine($"Adicionado:\n\nDia: {dias[inicio]} Temperatura: {temp}º C");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Lista cheia!");
        Console.WriteLine("");
    }
}

void CalcularMédia()
{
    if (inicio == 0)
    {
        Console.WriteLine("Existe apenas 1 dia inserido, não há como calcular a média...");
    }
    else
    {
        float soma = 0;
        float media;
        for (int i = 0; i <= inicio; i++)
        {
            soma += temperaturas[i];
        }
        media = soma / (inicio + 1);
        Console.WriteLine("");
        Console.WriteLine($"A média é: {media}º C");
        Console.WriteLine("");
    }
}

void MostrarDados()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nTemperaturas:\n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"\n{dias[i]}: {temperaturas[i]}º C");
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("A lista está vazia");
        Console.WriteLine("");
    }
}
void mostrarNumeroMaiorEMenor()
{
    float eMaior = temperaturas[0];
    float eMenor = temperaturas[0];

    for (int i = 1; i <= inicio; i++)
    {
        if (temperaturas[i] > eMaior)
        {
            eMaior = temperaturas[i];
        }
        if (temperaturas[i] < eMenor)
        {
            eMenor = temperaturas[i];
        }
    }
    Console.WriteLine("");
    Console.WriteLine($"A Maior Temperatura registrada é : {eMaior}º C");
    Console.WriteLine($"A Menor Temperatura registrada é : {eMenor}º C");
    Console.WriteLine("");

}