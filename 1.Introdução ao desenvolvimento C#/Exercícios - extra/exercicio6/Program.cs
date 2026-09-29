//Valor base pedágios
float valorPdagioMoto, valorPedagioCarro, valorPedagioCaminhao;
//estrutura de repetição do valor base dos pedágios
bool valorCorretoPedagio = false;

//1º switch Menu Principal
int opcao, opcaoCadastro;


//2º Switch Sub Menu
//MOTO
string nomeProprietarioMoto;
int idadeProprietarioMoto, anoFabricacaoMoto;


//CARROS
string nomeProprietarioCarroUm;
int idadeProprietarioCarroUm, anoFabricacaoCarroUm;
string nomeProprietarioCarroDois;
int idadeProprietarioCarroDois, anoFabricacaoCarroDois;
string nomeProprietarioCarroTres;
int idadeProprietarioCarroTres, anoFabricacaoCarroTres;


//CAMINHÃO



do
{
    // Console.WriteLine("Informe o valor do pedágio para MOTO: ");
    // valorPdagioMoto = float.Parse(Console.ReadLine());

    // Console.WriteLine("Informe o valor do pedágio para CARRO: ");
    // valorPedagioCarro = float.Parse(Console.ReadLine());

    // Console.WriteLine("Informe o valor do pedágio para CAMINHÃO: ");
    // valorPedagioCaminhao = float.Parse(Console.ReadLine());

    valorPdagioMoto = 8;
    valorPedagioCarro = 10;
    valorPedagioCaminhao = 15;

    if ((valorPedagioCarro > valorPdagioMoto) && (valorPedagioCarro < valorPedagioCaminhao))
    {
        valorCorretoPedagio = true;
    }
} while (valorCorretoPedagio != false);

Console.WriteLine("Bem vindo ao sistema de Pedágios");
Console.WriteLine("Selecione uma opção: \n1 - Cadastro \n2 - Operações \n0 - Sair");
opcao = int.Parse(Console.ReadLine());

switch (opcao)
{
    case 1:
        Console.WriteLine("Informe quais veículos deseja cadastrar: \n1 - Moto \n2 - Carro \n3 - Caminhão \n\n 0 -  Voltar para o menu anterior");
        opcaoCadastro = int.Parse(Console.ReadLine());
        switch (opcaoCadastro)
        {
            case 1:
                Console.WriteLine("\n\nPara o cadastro de sua moto:\n");
                Console.WriteLine("Informe:\n");
                Console.WriteLine("Nome do Proprietário:\n");
                nomeProprietarioMoto = Console.ReadLine();
                Console.WriteLine("Idade do Proprietário:\n");
                idadeProprietarioMoto = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de fabricação da Moto:\n");
                anoFabricacaoMoto = int.Parse(Console.ReadLine());
                break;



            case 2:
            //carro UM
                Console.WriteLine("\n\nPara o cadastro de seus carros:\n");
                Console.WriteLine("Primeiro carro: \n");
                Console.WriteLine("Nome do Proprietário do Carro UM:\n");
                nomeProprietarioCarroUm = Console.ReadLine();
                Console.WriteLine("Idade do Proprietário do Carro UM:\n");
                idadeProprietarioCarroUm = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de fabricação do Carro UM:\n");
                anoFabricacaoCarroUm = int.Parse(Console.ReadLine());
            //Carro Dois
                Console.WriteLine("\n\nPara o cadastro de seus carros:\n");
                Console.WriteLine("Primeiro carro: \n");
                Console.WriteLine("Nome do Proprietário do Carro Dois:\n");
                nomeProprietarioCarroDois = Console.ReadLine();
                Console.WriteLine("Idade do Proprietário do Carro Dois:\n");
                idadeProprietarioCarroDois = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de fabricação do Carro Dois:\n");
                anoFabricacaoCarroDois = int.Parse(Console.ReadLine());
            //Carro 
                Console.WriteLine("\n\nPara o cadastro de seus carros:\n");
                Console.WriteLine("Primeiro carro: \n");
                Console.WriteLine("Nome do Proprietário do Carro Tres:\n");
                nomeProprietarioCarroTres = Console.ReadLine();
                Console.WriteLine("Idade do Proprietário do Carro Tres:\n");
                idadeProprietarioCarroTres = int.Parse(Console.ReadLine());
                Console.WriteLine("Ano de fabricação do Carro Tres:\n");
                anoFabricacaoCarroTres = int.Parse(Console.ReadLine());
































                break;
            default:
        }
































        break;
    case 2:

        break;
    case 3:

        break;
    case 0:

        break;
}