int distancia, velocidadeMedia, horas;

Console.WriteLine("Informe a Distancia percorrida em Km: (Ex:1000) ");
distancia = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o tempo gasto em horas: (Ex:9)");
horas = int.Parse(Console.ReadLine());

//calculo
velocidadeMedia = distancia / horas;

Console.WriteLine($"A velocidade média foi de: {velocidadeMedia} Km/h");