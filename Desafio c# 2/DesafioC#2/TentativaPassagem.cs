public class TentativaPassagem : Passagem
{
    public string Motivo { get; set; }
    public TentativaPassagem(Veiculo automovel, decimal valorPedagio, string motivo) : base(automovel, valorPedagio)
    {
        Motivo = motivo;
    }

}