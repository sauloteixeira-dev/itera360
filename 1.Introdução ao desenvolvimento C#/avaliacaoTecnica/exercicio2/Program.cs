string nome;
double valorMensalidade, desconto, idade;



Console.WriteLine("Bem vindo a Academia dos que pagam e não vem..");

Console.WriteLine("Informe seu nome: ");
nome = Console.ReadLine();


Console.WriteLine("Informe sua idade: ");
idade = double.Parse(Console.ReadLine());


Console.WriteLine("Informe o valor da sua mensalidade: exemplo: 45,90 ");
valorMensalidade = double.Parse(Console.ReadLine());


desconto = valorMensalidadeComDesconto(idade);


Console.WriteLine($"O falor da sua mensalidade é de {valorMensalidade},\n com nosso desconto fica em {valorMensalidade - (desconto * valorMensalidade)}");


double valorMensalidadeComDesconto(double idade)
{
    double desconto = 0;
    if (idade >= 40 && idade <= 50)
    {
        desconto = 0.1;
    }
    else if (idade > 50)
    {
        desconto = 0.2;
    }
    return desconto;

}
