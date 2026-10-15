class CartaoDeCredito : IPagamento
{
    public void Pagar() { System.Console.WriteLine("Tá Pago! Cartão de Crédito"); }

    public void CancelarPagamento() { System.Console.WriteLine("Cancelado !!!"); }
}