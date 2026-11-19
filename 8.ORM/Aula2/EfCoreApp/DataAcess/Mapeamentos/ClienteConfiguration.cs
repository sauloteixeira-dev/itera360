using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes").HasKey(cliente=>cliente.Id);

        builder.Property(Cliente=>Cliente.Id).HasColumnName("ClienteID");
        builder.Property(Cliente=>Cliente.Nome).HasColumnName("Nome");
        builder.Property(Cliente=>Cliente.Email).HasColumnName("Email");
        
    }
}
