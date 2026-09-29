/*
Ano     ano de uso intensivo
1       3                       3      
2       2                       5
3       1                       6
4       1                       7
5       1                       8
6       1                       9
7                               10
8                               11
9                               12
10                              13 ...

*/


int idadeEquipamento, usoIntensivo;
string nomeAparelho;


Console.WriteLine("Informe o nome do aparelho: ");
nomeAparelho = Console.ReadLine();

Console.WriteLine("Informe a idade do equipamento: ");
idadeEquipamento = int.Parse(Console.ReadLine());


usoIntensivo = calcularVidaUtil(idadeEquipamento);

Console.WriteLine($"O {nomeAparelho}, tem os seguintes anos de uso: {usoIntensivo}");




int calcularVidaUtil(int age)
{
    int usoIntensivo = 0;
    if (age == 1)
    {
        usoIntensivo = 3;
    }
    else if (age == 2)
    {
        usoIntensivo = 3 + 2;
    }
    else if (age >= 3)
    {
        usoIntensivo = age + 3;
    }
    return usoIntensivo;
}
