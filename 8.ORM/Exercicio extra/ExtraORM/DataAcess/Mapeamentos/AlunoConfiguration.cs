using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        builder.ToTable("Aluno").HasKey(aluno => aluno.AlunoId);

        builder.Property(Aluno => Aluno.AlunoId).HasColumnName("AlunoId");
        builder.Property(Aluno => Aluno.AlunoNome).HasColumnName("AlunoNome");
        builder.Property(Aluno => Aluno.AlunoIdade).HasColumnName("AlunoIdade");
        builder.Property(Aluno => Aluno.AlunoDataNascimento).HasColumnName("AlunoDataNascimento");
        builder.Property(Aluno => Aluno.AlunoCidade).HasColumnName("AlunoCidade");
        builder.Property(Aluno => Aluno.AlunoEstado).HasColumnName("AlunoEstado");
    }
}