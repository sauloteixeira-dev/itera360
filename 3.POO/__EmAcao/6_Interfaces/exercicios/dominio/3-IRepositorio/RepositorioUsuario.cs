using System.Reflection;

class RepositorioUsuario : IRepositorio
{
    public void Adicionar() { System.Console.WriteLine("Usuario Adiconado!"); }
    public void Atualizar(){System.Console.WriteLine("Usuário Atualizado!");}
    public void Remover() { System.Console.WriteLine("Removido - Usuário!"); }
}