using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;
using EfCoreApp.Migrations;

namespace DataAcess;

public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
{
    public void Configure(EntityTypeBuilder<Pedido> builder)
    {
        builder.ToTable("Pedidos").HasKey(pedido => pedido.Id);

        builder.Property(pedido => pedido.Id).HasColumnName("PedidoID");
        builder.Property(pedido => pedido.Nome).HasColumnName("Data");
        builder.Property(pedido => pedido.ValorTotal).HasColumnName("ValorTotal").HasPrecision(18, 2);

        builder
            .HasOne(pedido => pedido.Cliente)
            .WithMany(cliente => cliente.Pedidos)
            .HasForeignKey(pedido => pedido.ClienteId);
    }
}
