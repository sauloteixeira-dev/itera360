public class Pedagio
{
    public static List<Passagem> Passagem = new List<Passagem>();
    public static List<TentativaPassagem> TentativaPassagem = new List<TentativaPassagem>();

    public decimal ObterValor(TipoVeiculo tipo)
    {
        if (tipo == TipoVeiculo.Moto) return 1.50m;
        if (tipo == TipoVeiculo.Carro) return 2.90m;
        return 18.90m;
    }
    public bool PassarPedagio()
    {
        return true;
    }

    public bool VerificarCancela()
    {
        return true;
    }
}