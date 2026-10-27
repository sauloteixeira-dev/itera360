Console.WriteLine("Digite um numero correspondente ao mês do ano: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch ((MesesDoAno)mes)
{
    case MesesDoAno.Janeiro:
        Console.WriteLine("Janeiro");
        break;
    case MesesDoAno.Fevereiro:
        Console.WriteLine("Fevereiro");
        break;
    case MesesDoAno.Marco:
        Console.WriteLine("Março");
        break;
    case MesesDoAno.Abril:
        Console.WriteLine("Abril");
        break;
    case MesesDoAno.Maio:
        Console.WriteLine("Maio");
        break;
    case MesesDoAno.Junho:
        Console.WriteLine("Junho");
        break;
    case MesesDoAno.Julho:
        Console.WriteLine("Julho");
        break;
    case MesesDoAno.Agosto:
        Console.WriteLine("Agosto");
        break;
    case MesesDoAno.Setembro:
        Console.WriteLine("Setembro");
        break;
    case MesesDoAno.Outubro:
        Console.WriteLine("Outubro");
        break;
    case MesesDoAno.Novembro:
        Console.WriteLine("Novembro");
        break;
    case MesesDoAno.Dezembro:
        Console.WriteLine("Dezembro");
        break;


}

/*O que é um enumerador (enum) em C#?
É uma estrutura de dados que permite representar um conjunto limitado de valores nomeados, como dias da semana ou meses do ano.

Por que utilizar enums em vez de constantes?
Enums tornam o código mais legível, evitam erros e facilitam a manutenção, além de serem reconhecidos pelo IntelliSense.

Como declarar um enum?
public enum MesesdoAno... exemplo

Como converter um número para um valor de enum?
MesesDoAno mes = (MesesDoAno)numero;

Enums consomem mais recursos que constantes?
Não, eles são armazenados como tipos numéricos simples, como int por padrão, o que os torna leves e eficientes.

Posso usar enums para valores duplicados?
Não é recomendado, pois o propósito dos enums é garantir valores únicos e compreensíveis.

Como validar se um valor é válido para um enum?
Use o método Enum.IsDefined:
    if(Enum.isDefined(typeof(MesesdoAno),valor))
    {
        é um valor valido

O que acontece se o valor fornecido pelo usuário não estiver no enum?
Se você tentar converter um número fora dos valores definidos, será lançada uma exceção. É recomendado validar a entrada antes da conversão.
    }

    É possível atribuir valores não sequenciais ao enum?
Sim, basta definir os valores desejados:
public enum Status
{
    Inativo = 0,
    Ativo = 1,
    Pendente = 5,
    Cancelado = 10
}

Enums podem ser utilizados em loops?
Sim! Você pode iterar sobre os valores do enum usando Enum.GetValues().

Exemplo:
foreach(MesesDoAno in Enum.GetValues(typeof(MesesDoAno)))
{
    Console.WriteLine(mes);
}

*/