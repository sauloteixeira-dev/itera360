//variável inicial
int inicio = -1;

//variáveis laços
int opcao;
int outraOpcao;

//variável tamanho do array
int tamanhoArray = 5;
int quantidadeNotasPorAno = 4;


// variaveis aluno
string nomeAluno;
double primeiraNotaBim, segundaNotaBim, terceiraNotaBim, quartaNotaBim;

//arrays
string[] alunos = new string[tamanhoArray];
double[] notas = new double[tamanhoArray * quantidadeNotasPorAno]; //20
string[] status = new string[tamanhoArray];

// double[,] joao = new double[5, 5]; coluna x linha

do
{
    Console.WriteLine("\n\nBem vindo ao cadastro de Notas dos Alunos\n\n");
    Console.WriteLine("Selecione uma opção:\n\n1 - Cadastro de Aluno\n2 - Listar Alunos\n3 - Atualizar notas do aluno\n4 - Remover Aluno\n5 - Relatórios\n\n0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Informe o NOME do aluno:");
            nomeAluno = Console.ReadLine();

            Console.WriteLine("Insira a nota do 1º bimestre do aluno");
            primeiraNotaBim = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota do 2º bimestre do aluno");
            segundaNotaBim = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota do 3º bimestre do aluno");
            terceiraNotaBim = double.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nota do 4º bimestre do aluno");
            quartaNotaBim = double.Parse(Console.ReadLine());
            CadastroAlunos(nomeAluno, primeiraNotaBim, segundaNotaBim, terceiraNotaBim, quartaNotaBim);
            break;
        case 2:
            mostrarAlunosCadastrados();
            break;
        case 3:
            //AtualizarNotaDosAlunos();
            break;
        case 4:
            //RemoverAlunoPeloNome();
            break;
        case 5:
            do
            {


                Console.WriteLine("\n\n======== Relátórios ========\n\n");
                Console.WriteLine("1 - Exibir alunos Aprovados e suas médias\n2 - Exibir total de alunos aprovados, em recuperação e reprovados\n3 - Exibir todos os alunos e sua situação final\n\n4 - Volar ao Menu Anterior");
                outraOpcao = int.Parse(Console.ReadLine());
                switch (outraOpcao)
                {

                    case 1:
                        //MostarAlunosAprovados();
                        break;
                    case 2:
                        //MostrarTotalDeAlunosAprRecRep();
                        break;
                    case 3:
                        //MostrarAlunosSituacaoFinal();
                        break;
                    case 4:
                        Console.WriteLine("\n\nRetornando...\n\n");
                        break;
                }
            } while (outraOpcao != 4);
            break;

        case 0:
            Console.WriteLine("Saindo...");
            break;
    }



} while (opcao != 0);


// Cadastro de Alunos 

void CadastroAlunos(string nome, double notaUm, double notaDois, double notaTres, double notaQuatro)
{
    double media = 0;

    if (inicio < alunos.Length)
    {
        if ((notaUm < 0 && notaUm > 10) || (notaDois < 0 && notaDois > 10) || (notaTres < 0 && notaTres < 10) || (notaQuatro < 0 && notaQuatro < 10))
        {
            Console.WriteLine("Opção inválida, notas não podem ser menores que 0 ou maiores que 10");
            return;
        }
        else
        {
            inicio++;

            // if (inicio == 0)
            // {
            alunos[inicio] = nome.ToUpper();//alunos[0] = joao-------- 0 --------1
            notas[inicio][inicio] = notaUm;
            notas[inicio + 1] = notaDois;//notas[1] = 6--------1--------2
            notas[inicio + 2] = notaTres;//notas[2] = 8--------2--------3
            notas[inicio + 3] = notaQuatro;//notas[3] = 8--------3--------4

            // }
            // else
            // {
            // for (int i = 4; i < notas.Length; i++)
            // {
            //     alunos[inicio] = nome.ToUpper();
            //     notas[i] = notaUm; //notas[4] = x
            //     notas[i + 1] = notaDois;//notas[5] = y
            //     notas[i + 2] = notaTres;//notas[6] = z
            //     notas[i + 3] = notaQuatro; // notas[7]
            // }

            media = notaUm + notaDois + notaTres + notaQuatro / 4;

            if (media >= 7)
            {
                Console.WriteLine($"Aluno : {nome} está: Aprovado!");
            }
            else if (media >= 5 && media < 7)
            {
                Console.WriteLine($"Aluno : {nome} está: Recuperação!");
            }
            else
            {
                Console.WriteLine($"Aluno : {nome} está: Reprovado!");
            }
        }
    }
}
// }


void mostrarAlunosCadastrados()
{
    if (inicio >= 0)
    {
        Console.WriteLine("\nAlunos Cadastrados:\n");

        for (int i = 0; i <= inicio; i++)
        {
            Console.WriteLine($"Nº: {i + 1} Aluno: {alunos[i]} | Notas: 1ª:{notas[inicio]} 2ª: {notas[i + 1]} 3ª: {notas[i + 2]} 4ª: {notas[i + 3]} | Status: {status[0]} aprovado? verificar");
            Console.WriteLine("");
        }
    }
    else
    {
        Console.WriteLine("\nA lista está vazia.\n");
    }
}