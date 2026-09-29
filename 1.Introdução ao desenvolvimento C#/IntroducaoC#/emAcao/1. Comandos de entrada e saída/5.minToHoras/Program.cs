int minutosInput;
int horas;
int minutos;

Console.WriteLine("Informe os minutos que deseja converter em horas e minutos: ");
minutosInput = int.Parse(Console.ReadLine());

horas = minutosInput / 60;
minutos = minutosInput % 60;

Console.WriteLine($"{horas}:{minutos:D2}");
