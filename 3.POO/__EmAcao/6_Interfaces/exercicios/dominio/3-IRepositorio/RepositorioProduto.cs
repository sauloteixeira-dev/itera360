class RepositorioProduto : IRepositorio
{
    public void Adicionar() { System.Console.WriteLine("Produto Adiconado!"); }
    public void Atualizar() { System.Console.WriteLine("Produto Atualizado!"); }
    public void Remover() { System.Console.WriteLine("Removido - Produto!"); }
}