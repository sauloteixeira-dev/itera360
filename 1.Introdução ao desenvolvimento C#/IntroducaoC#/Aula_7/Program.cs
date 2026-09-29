string userDigit;
string passDigit;
string desejaEntrar;

Console.WriteLine("\nDeseja entrar?\n\n 1 - Sim\n 2 - Não\n");
desejaEntrar = Console.ReadLine();

switch (desejaEntrar)
{
    case "1":
        Console.WriteLine("\nInforme seu usuário: \n");
        userDigit
     = Console.ReadLine();


        switch (userDigit)
        {
            case "admin":
                Console.WriteLine("\nUsuário correto...\n");
                break;
            default:
                Console.WriteLine("\nUsuário Incorreto...\n");
                break;
        }

        Console.WriteLine("Informe sua senha: ");
        passDigit = Console.ReadLine();

        switch (passDigit)
        {
            case "admin":
                Console.WriteLine("\nSenha correta!...\n Entrando no app...\n");
                break;
            default:
                Console.WriteLine("\nSenha incorreta ... \n Tente novamente\n");
                break;
        }
        break;
    case "2":
        Console.WriteLine("\nGood Bye!\n");
        break;
    default:
        Console.WriteLine("\nError, inserir uma opção!\n");
        break;
}



