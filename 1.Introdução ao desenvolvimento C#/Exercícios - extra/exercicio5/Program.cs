string nome;
string nomeDoPrato;
string turno;
float hora;
float minutos;
float taxa;

Console.WriteLine("\n\nBem vindo ao APP de verificação de taxas\n");

Console.WriteLine("Informe Seu nome: \n");
nome = Console.ReadLine();

Console.WriteLine("Informe o nome do prato\n");
nomeDoPrato = Console.ReadLine();

Console.WriteLine("Informe o horario do pedido: de 0 a 23h\n");
hora = float.Parse(Console.ReadLine());

Console.WriteLine("Informe os minutos do pedido: de 0 a 60 min\n");
minutos = float.Parse(Console.ReadLine());


calcularTaxa(definirTurno(hora), obterValorTaxa(turno));


Console.WriteLine($"\n\nDe acordo com o horario: {hora}:{minutos}, o prato: {nomeDoPrato} de {nome}, custará: {taxa:C}\n\n");



string definirTurno(float hora)
{
    if (hora >= 6 && hora <= 11)
    {
        turno = "Manha";
    }
    else if (hora >= 12 && hora <= 17)
    {
        turno = "Tarde";
    }
    else if (hora >= 18 && hora <= 23)
    {
        turno = "Noite";
    }
    else
    {
        turno = "Madrugada";
    }
    return turno;
}

float obterValorTaxa(string turno)
{
    if (turno == "Manha")
    {
        taxa = 5;
    }
    else if (turno == "Tarde")
    {
        taxa = 9;
    }
    else if (turno == "Noite")
    {
        taxa = 13;
    }
    else
    {
        taxa = 18;
    }
    return taxa;
}

void calcularTaxa(string time, float price)
{
    definirTurno(hora);
    obterValorTaxa(turno);
}



