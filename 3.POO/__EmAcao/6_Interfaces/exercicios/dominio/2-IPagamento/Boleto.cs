class Boleto : IPagamento
{
    public void Pagar() { System.Console.WriteLine("Pago via Boleto!"); }

    public void CancelarPagamento() { System.Console.WriteLine("Boleto Cancelado!"); }
}