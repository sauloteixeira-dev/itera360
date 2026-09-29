float altura, peso, imc;
string variacao;

Console.WriteLine("Informe sua altura: ");
altura = float.Parse(Console.ReadLine());


Console.WriteLine("Informe seu peso: ");
peso = float.Parse(Console.ReadLine());

imc = peso / (altura * altura);
if (imc < 1.85)

{
   variacao = "Magro";
}
else if (imc >= 1.85 && imc <= 24.9)
{
    variacao = "Normal";
}
else
{
    variacao = "Sobrepeso";
}

Console.WriteLine($"Seu IMC é de: {imc:.} e voce está: {variacao}");