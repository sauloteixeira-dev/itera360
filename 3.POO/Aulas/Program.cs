internal class Program
{
    private static void Main(string[] args)
    {
        bool acelere = false;
        CarroDeCorrida ferrari = new CarroDeCorrida();

        ferrari.Cor = "Vermelho";
        ferrari.Categoria = "F1";
        ferrari.Motor = "Ferrari";
        ferrari.Potencia = 800;

        ferrari.Ligar();

        CarroDeCorrida Mercedes = new CarroDeCorrida();

        Mercedes.Cor = "Cinza";
        Mercedes.Categoria = "F1";
        Mercedes.Motor = "Mercedes";
        Mercedes.Potencia = 800;

        Mercedes.Ligar();


        do
        {
            System.Console.WriteLine("Digite S para acelerar");
            if (Console.ReadLine() == "s")
            {
                acelere = true;

                ferrari.Acelerar();
                Mercedes.Acelerar();
            }
            else
            {
                acelere = false;
            }
            System.Console.WriteLine($"A velocidade da Ferrari é de: {ferrari.Velocidade}\n\nA velocidade da Mercedes é de: {Mercedes.Velocidade}");

        } while (acelere);


    }
}