//Conversão Implícita

int expNum1 = 50;
short expNum2 = 10;
byte expNum3 = 161;

long numLong = expNum1;
int numShort = expNum2;
short numByte = expNum3;


Console.WriteLine("Esse é um numero: int: " + expNum1 + " to long: " + numLong);// 50    50
Console.WriteLine("Esse é um numero: short: " + expNum2 + " to int: " + numShort);//10    10
Console.WriteLine("Esse é um numero: byte: " + expNum1 + " to short: " + numByte); //50   161


//-------------------------------


//Conversão Explícita (Casting)
short y = 200;
byte k = 199;
int x = 10;
long p = 800;


int numero = (short)k;
int numero2 = (int)y;
int numero3 = (int)x;
int numero4 = (int)p;

Console.WriteLine("\n\nConversão explícita\n");
Console.WriteLine("Esse é um numero " + k + ": Byte to short: " + numero);
Console.WriteLine("Esse é um numero " + y + ": short to int: " + numero2);
Console.WriteLine("Esse é um numero " + x + ": int to int: " + numero3);
Console.WriteLine("Esse é um numero " + p + ": long to int: " + numero4);

//quando há risco de perda de dados
double numDouble = 8.49;
int valorIntDouble = (int)numDouble;
Console.WriteLine(valorIntDouble); //8


long numLong2 = 89078501;
short valorLongShort = (short)numLong2;
Console.WriteLine(valorLongShort); //15077

//-------------------------------

//Conversão usando Classes

string typeNum = "789654";

int numConvert = Convert.ToInt32(typeNum);

Console.WriteLine("Essa string: " + typeNum + " Foi convertida em numero: " + numConvert);



