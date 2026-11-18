namespace Dominio;

public class Cliente
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }



    //cliente tem varios pedidos = (lista)
    public List<Pedido> Pedidos { get; set; }
}