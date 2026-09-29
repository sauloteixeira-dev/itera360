float[] notas = new float[5];
float nota;
int opcao;
int inicio = -1;
int numero;

do
{
    Console.WriteLine("\nInforme a Opção desejada:\n\n1 - Inserir nota\n2 - Remover nota\n3 - Calcular média\n4 - Mostrar lista de notas\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());
    if (opcao == 1)
    {
        Console.WriteLine("\nInforme a nota que deseja inserir\n");
        nota = float.Parse(Console.ReadLine());
        AdicionarNovaNota(nota);
    }
    else if (opcao == 2)
    {
        if (inicio >= 0)
        {
            MostrarNotas();
            Console.WriteLine("Informe um indice para remover a nota: ");
            numero = int.Parse(Console.ReadLine());
            RemoverPorNumero(numero);
        }
        else
        {
            Console.WriteLine("Não há notas para remover");
        }
    }
    else if (opcao == 3)
    {
        CalcularMediaNotas();
    }
    else if (opcao == 4)
    {
        MostrarNotas();
    }
} while (opcao != 0);

void AdicionarNovaNota(float nota)
{
    if (inicio < 4)
    {
        inicio++;
        notas[inicio] = nota;
        Console.WriteLine($"Adicionado: Nota: {nota} na posição {inicio + 1}");
    }
    else
    {
        Console.WriteLine("Lista cheia");
    }
}

void RemoverPorNumero(int numeroEscolhido)
{

    int indice = numeroEscolhido - 1;

    if (inicio >= 0 && indice >= 0 && indice <= inicio)
    {
        Console.WriteLine($"\nRemovendo: Index: {indice + 1}  Nota: {notas[indice]}");


        for (int i = indice; i < inicio; i++)
        {
            notas[i] = notas[i + 1];
        }
        notas[inicio] = 0;
        inicio--;

        Console.WriteLine($"Removido com sucesso!");
    }
    else
    {
        Console.WriteLine("\nOpção inválida!");
    }
}

void CalcularMediaNotas()
{
    float soma = 0;
    float media;
    for (int i = 0; i <= inicio; i++)
    {
        soma += notas[i];
    }
    media = soma / (inicio + 1);
    Console.WriteLine("");
    Console.WriteLine($"A média é: {media}");
    Console.WriteLine("");
}

void MostrarNotas()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nNotas adicionadas:\n");
        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"{i + 1}ª Nota: {notas[i]}");
        }
    }
    else
    {
        Console.WriteLine("A lista está vazia");
    }
}

