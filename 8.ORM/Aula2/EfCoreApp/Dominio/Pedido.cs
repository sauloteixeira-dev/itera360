namespace Dominio;

public class Pedido
{
    public int Id { get; set; }
    public DateTime Nome { get; set; }
    public decimal ValorTotal { get; set; }

    //FK
    public int ClienteId{get;set;}
    public Cliente Cliente { get; set; }
}