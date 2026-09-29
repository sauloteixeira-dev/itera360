
string nome1;
string nome2;
string nome3;

int age1;
int age2;
int age3;

float nota1;
float nota2;
float nota3;

float notaFinal;
float media;

int cadastroQtd;
bool qtdAlunos = true;

do
{

        Console.WriteLine("Bem vindo ao cadastro de notas dos alunos!\n\nDeseja cadastrar quantos Alunos? 2 ou 3 Alunos?\n");
        cadastroQtd = int.Parse(Console.ReadLine());

        if (cadastroQtd == 2)
        {
                //Aluno 1
                Console.WriteLine("Informe o NOME do 1º Aluno: \n");
                nome1 = Console.ReadLine();
                Console.WriteLine($"Informe a IDADE do {nome1}: \n");
                age1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o NOTA do {nome1}: \n");
                nota1 = float.Parse(Console.ReadLine());

                //Aluno 2
                Console.WriteLine("Informe o NOME do 2º Aluno: \n");
                nome2 = Console.ReadLine();
                Console.WriteLine($"Informe a IDADE do {nome2} : \n");
                age2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o NOTA do {nome2}: \n");
                nota2 = float.Parse(Console.ReadLine());

                //Calculo da média
                media = MediaDoisAlunos(nota1, nota2);

                //Nota Final dos 3
                notaFinal = MaiorNotaEntreDoisAlunos(nota1, nota2);
                string temp;
                if (notaFinal == nota1)
                {
                        temp = nome1;
                }
                else
                {
                        temp = nome2;
                }

                Console.WriteLine("\n\n==========================\n");
                Console.WriteLine($"\n1° Aluno: Nome: {nome1}\n Idade: {age1}\n Nota: {nota1}\n Status: {Status(nota1)}  \n\n");
                Console.WriteLine("==========================");
                Console.WriteLine($"\n2° Aluno: Nome: {nome2}\n Idade: {age2}\n Nota: {nota2}\n Status: {Status(nota2)}  \n\n");
                Console.WriteLine("==========================");

                //Maior nota
                Console.WriteLine($"\nA maior nota é do aluno(a): {temp} com Nota: {notaFinal}\n");
                Console.WriteLine("==========================\n");

                //Maior Média
                Console.WriteLine($"A média das notas é de: {media.ToString("f")} \n");


                float MediaDoisAlunos(float a, float b)
                {
                        return (a + b) / 2;
                }

                float MaiorNotaEntreDoisAlunos(float a, float b)
                {
                        if (a > 0 && a > b)
                        {
                                return a;
                        }
                        else
                        {
                                return b;
                        }

                }

                string Status(float n)
                {
                        string resposta;

                        if (n < 6)
                        {
                                resposta = "Reprovado";
                        }
                        else if (n > 6 && n < 7.9)
                        {
                                resposta = "Aprovado";
                        }
                        else
                        {
                                resposta = "Aprovado com mérito";
                        }

                        return resposta;
                }

                //Sai do Loop
                qtdAlunos = false;
        }
        else if (cadastroQtd == 3)
        {
                //Aluno 1
                Console.WriteLine("Informe o NOME do 1º Aluno: \n");
                nome1 = Console.ReadLine();
                Console.WriteLine($"Informe a IDADE do {nome1}: \n");
                age1 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o NOTA do {nome1}: \n");
                nota1 = float.Parse(Console.ReadLine());

                //Aluno 2
                Console.WriteLine("Informe o NOME do 2º Aluno: \n");
                nome2 = Console.ReadLine();
                Console.WriteLine($"Informe a IDADE do {nome2}: \n");
                age2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o NOTA do {nome2}: \n");
                nota2 = float.Parse(Console.ReadLine());

                //Aluno 3
                Console.WriteLine("Informe o NOME do 3º Aluno: \n");
                nome3 = Console.ReadLine();
                Console.WriteLine($"Informe a IDADE do {nome3}: \n");
                age3 = int.Parse(Console.ReadLine());
                Console.WriteLine($"Informe o NOTA do {nome3}: \n");
                nota3 = float.Parse(Console.ReadLine());

                //Calculo da média
                media = Media(nota1, nota2, nota3);

                //Nota Final dos 3
                notaFinal = MaiorNotaEntreAlunos(nota1, nota2, nota3);

                //Inserir nome do Aluno na maior nota
                string temp;
                if (notaFinal == nota1)
                {
                        temp = nome1;
                }
                else if (notaFinal == nota2)
                {
                        temp = nome2;
                }
                else
                {
                        temp = nome3;
                }



                //Todos Cadastros
                Console.WriteLine("\n\n==========================\n");
                Console.WriteLine($"\n1° Aluno: Nome: {nome1}\n Idade: {age1}\n Nota: {nota1}\n Status: {Status(nota1)}  \n\n");
                Console.WriteLine("==========================");
                Console.WriteLine($"\n2° Aluno: Nome: {nome2}\n Idade: {age2}\n Nota: {nota2}\n Status: {Status(nota2)}  \n\n");
                Console.WriteLine("==========================");
                Console.WriteLine($"\n3° Aluno: Nome: {nome3}\n Idade: {age3}\n Nota: {nota3}\n Status: {Status(nota3)}  \n\n");

                //Maior nota
                Console.WriteLine($"\nA maior nota é do aluno(a): {temp} com Nota: {notaFinal}\n");
                Console.WriteLine("==========================\n");

                //Maior Média
                Console.WriteLine($"A média das notas é de: {media.ToString("f")} \n");





                //Cálculo da Média
                float Media(float a, float b, float c)
                {
                        return (a + b + c) / 3;
                }

                //Cálculo Maior Nota
                float MaiorNotaEntreAlunos(float a, float b, float c)
                {
                        if (a > 0 && a > b && a > c)
                        {
                                return a;
                        }
                        else if (b > 0 && b > a && b > c)
                        {
                                return b;
                        }
                        else
                        {
                                return c;
                        }

                }

                //Status 
                string Status(float n)
                {
                        string resposta;

                        if (n < 6)
                        {
                                resposta = "Reprovado";
                        }
                        else if (n > 6 && n < 7.9)
                        {
                                resposta = "Aprovado";
                        }
                        else
                        {
                                resposta = "Aprovado com mérito";
                        }

                        return resposta;
                }

                //Sai do loop
                qtdAlunos = false;
        }
        else
        {
                Console.WriteLine("\n\n===Insira outro valor===\n\n");
        }





















        //------------------------------------------------------------------------------


        //Funções






} while (qtdAlunos);