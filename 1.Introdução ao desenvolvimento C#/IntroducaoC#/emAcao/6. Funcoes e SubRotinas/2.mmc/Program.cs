int n1 = 0;
int n2 = 0;
int mmc;
int mdc = 0;

Console.WriteLine("Informe o primeiro numero: ");
n1 = int.Parse(Console.ReadLine());


Console.WriteLine("Informe o segundo numero: ");
n2 = int.Parse(Console.ReadLine());

calculoMMc(n1, n2);

Console.WriteLine(mmc);

int calculoMMc(int n1, int n2)
{

    int a = n1;
    int b = n2;
    int rest;

    while (b != 0)
    {
        rest = a % b;
        a = b;
        b = rest;
        mdc = a;
    }

    mmc = n1 * n2 / mdc;

    return mmc;
}