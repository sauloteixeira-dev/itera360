

//Inteiro com Parse
Console.WriteLine("Informe um Número inteiro");
string numImput = Console.ReadLine();
int num = int.Parse(numImput);


//decimal
Console.WriteLine("Insira um valor utilizando ',' :");
string floatInput = Console.ReadLine();
float flo = float.Parse(floatInput);


//char
Console.WriteLine("Apenas 1 Caractere: ");
string charInput = Console.ReadLine();
char cha = char.Parse(charInput);

//bool
Console.WriteLine("Insira um valor booleano: ");
string boolInput = Console.ReadLine();
bool boo = bool.Parse(boolInput);




Console.WriteLine("\nInteiro: " + num);
Console.WriteLine("Salário: " + flo.ToString("f") + ".");
Console.WriteLine("Caractere: " + cha);
Console.WriteLine("Boleano: " + boo);







