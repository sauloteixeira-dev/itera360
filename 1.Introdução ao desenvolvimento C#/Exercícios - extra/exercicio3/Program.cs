string nome;
double anoFabricacao, ipva, anoAtual = 2026, idadeDoVeiculo, valorCheioIPVA;


Console.WriteLine("Informe o nome do proprietário: ");
nome = Console.ReadLine();

Console.WriteLine("Informe o ano do veículo: ");
anoFabricacao = double.Parse(Console.ReadLine());

Console.WriteLine("Informe o valor cheio do IPVA ");
valorCheioIPVA = double.Parse(Console.ReadLine());


idadeDoVeiculo = anoAtual - anoFabricacao;

Console.WriteLine(idadeDoVeiculo);

if (idadeDoVeiculo > 20)
{
    ipva = valorCheioIPVA * 0;
    Console.WriteLine($"\nSr.(a) {nome} seu veículo está insento de pagamento do IPVA. Com {idadeDoVeiculo}, o valor a pagar é: {ipva:C}");
}
else if (idadeDoVeiculo > 15 && idadeDoVeiculo <= 20)
{
    ipva = 0.5 * valorCheioIPVA;
    Console.WriteLine($"\nGrande desconto {nome}, com a idade do veículo:{idadeDoVeiculo:D0}, o valor do seu IPVA é de : {ipva:C}");
}
else if (idadeDoVeiculo > 10 && idadeDoVeiculo < 14)
{
    ipva = 0.2 * valorCheioIPVA;
    Console.WriteLine($"\nA idade do veículo é: {idadeDoVeiculo}, o valor do seu IPVA é de: {ipva:C}, {nome}");
}
else
{
    Console.WriteLine($"O Valor do seu ipva é de: {valorCheioIPVA:C}, seu veículo é relativamente novo, {idadeDoVeiculo} anos.");
}



