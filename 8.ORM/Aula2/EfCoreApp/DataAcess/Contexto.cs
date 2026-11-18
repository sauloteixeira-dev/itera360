using Microsoft.EntityFrameworkCore;
using Dominio;

namespace DataAcess;

public class Contexto : DbContext
{
    /// <summary>
    /// Define o conjunto de entidades Cliente.
    /// </summary>
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Pedido> Pedidos{get;set;}

    /// <summary>
    /// Configura as Opções de conexão com o banco de dados
    /// </summary>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-58UEHOH\\SQLEXPRESS;Database=AppLojaVirtual;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    /// <summary>
    /// Aplica as configurações de entidade para o modelo do banco de dados.
    /// </summary>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Substitua 'ClienteConfiguration' pelo nome exato da sua classe de mapeamento
        modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        modelBuilder.ApplyConfiguration(new PedidoConfiguration());
    }
}
