int n1, n2;
string opcao;


do
{
    Console.WriteLine("primeiro numero: ");
    n1 = int.Parse(Console.ReadLine());

    Console.WriteLine("segundo numero: ");
    n2 = int.Parse(Console.ReadLine());

    Console.WriteLine("Selecione uma opção: 1-Adição\n2-Subtração\n3-Multiplicação\n4-Divisão\n 0-Sair");
    opcao = Console.ReadLine();

    calcule(n1, n2, opcao);

} while (opcao != "0");




int A(int a, int b)
{
    int soma = a + b;
    return soma;
}
int S(int a, int b)
{
    int sub = a - b;
    return sub;
}
int M(int a, int b)
{
    int mult = a * b;
    return mult;
}
int D(int a, int b)
{
    int div = a / b;
    return div;
}

void calcule(int a, int b, string operacao)
{
    if (operacao == "1")
    {
        string parametro = "ADIÇÃO";
        int calculoAdicao = A(a, b);
        resultado(calculoAdicao, parametro);

    }
    else if (operacao == "2")
    {
        string parametro = "SUBTRAÇÃO";
        int calculoSub = S(a, b);
        resultado(calculoSub, parametro);

    }
    else if (operacao == "3")
    {
        string parametro = "MULTIPLICAÇÃO";
        int calculoMult = M(a, b);
        resultado(calculoMult, parametro);
    }
    else if (operacao == "4")
    {
        string parametro = "DIVISÃO";
        int calculoDiv = D(a, b);
        resultado(calculoDiv, parametro);
    }




}


static void resultado(int a, string resultado)
{
    Console.WriteLine($"A resposta da {resultado} é: {a}");
}


