public class Pedagio
{
    // NOVO: as duas "gavetas". Sendo static, existe uma só para o programa inteiro
    public static List<Passagem> Passagens = new List<Passagem>();
    public static List<TentativaPassagem> Tentativas = new List<TentativaPassagem>();

    // NOVO: o cálculo do valor, que estava duplicado, agora fica em um só lugar
    public static decimal ObterValor(TipoVeiculo tipo)
    {
        if (tipo == TipoVeiculo.Moto) return 1.50m;
        if (tipo == TipoVeiculo.Carro) return 2.90m;
        return 18.90m;
    }

    // sem alterações
    public bool PassarPedagio()
    {
        return true;
    }

    public bool VerificarCancela()
    {
        return true;
    }
}