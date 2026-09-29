//Estruturas de Repetição

//FOR

// int banhos = 0;

// for (banhos = 1; banhos <= 10; banhos++)
// {
//     Console.WriteLine($"Dar banho no dog {banhos.ToString()}");
// }


//-----------------------------------------------------------------------

//WHILE

// bool haveDog = true;
// string answer;
// Console.WriteLine("Dar banho no Dog??");

// while (haveDog)
// {
//     Console.WriteLine("Ainda tem Dog?");
//     answer = Console.ReadLine();
//     if (answer == "s" || answer == "S")
//     {
//         Console.WriteLine("\nDando banho no Dog!\n");
//         haveDog = true;
//     }
//     else
//     {
//         haveDog = false;
//     }
// }

//-----------------------------------------------------------------------

//DO-WHILE

// string answer;
// bool haveDog;
// do 
// {
//     Console.WriteLine("Tem Dog?");
//     answer = Console.ReadLine();

//     if (answer == "s")

//     {
//         Console.WriteLine("\nDando banho no Dog!\n");
//         haveDog = true;
//     }
//     else
//     {
//         haveDog = false;
//     }


// } while (haveDog);


//-----------------------------------------------------------------------


//Exercício 1

for (int i = 0; i <= 18; i++)
{
     if(i%2==0){
        Console.WriteLine($"O numero agora é: {i}");
     }


}

//-----------------------------------------------------------------------


//Exercício 2

int num;
int resultado = 0;
bool verificador = true;

do
{
    Console.WriteLine("Digine um numero para somar, ou 0 para sair.");
    num = int.Parse(Console.ReadLine());

    if (num != 0)
    {
        resultado += num;
    }
    else
    {

        Console.WriteLine("Acabou");
        verificador = false;
    }
    Console.WriteLine(resultado);

} while (verificador);


//-----------------------------------------------------------------------


//Exercício 3

bool verific;
string password = "C#Rocks";
string senha;

do
{
    Console.WriteLine("Insira sua senha: \n");
    senha = Console.ReadLine();

    if (senha == password)
    {
      Console.WriteLine("\nUsuário logado ✔\n");
        verific = false;
    }
    else
    {
        Console.WriteLine("\nSenha Incorreta ❌\n");
        verific = true;
    }

} while (verific);


//-----------------------------------------------------------------------






