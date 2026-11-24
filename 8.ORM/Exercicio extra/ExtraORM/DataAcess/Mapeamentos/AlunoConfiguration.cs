using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class AlunoConfiguration : IEntityTypeConfiguration<Aluno>
{
    public void Configure(EntityTypeBuilder<Aluno> builder)
    {
        // Tabela e chave primária
        builder.ToTable("Aluno");
        builder.HasKey(aluno => aluno.AlunoId);

        // Propriedades
        builder.Property(aluno => aluno.AlunoId)
            .HasColumnName("AlunoId");

        builder.Property(aluno => aluno.AlunoNome)
            .HasColumnName("AlunoNome");

        builder.Property(aluno => aluno.AlunoIdade)
            .HasColumnName("AlunoIdade");

        builder.Property(aluno => aluno.AlunoDataNascimento)
            .HasColumnName("AlunoDataNascimento");

        builder.Property(aluno => aluno.AlunoCidade)
            .HasColumnName("AlunoCidade");

        builder.Property(aluno => aluno.AlunoEstado)
            .HasColumnName("AlunoEstado");

        // Relacionamento 1:N com Matricula
        builder.HasMany(aluno => aluno.Matriculas)
            .WithOne(matricula => matricula.Aluno)
            .HasForeignKey(matricula => matricula.AlunoId);

        // Relacionamento 1:N com Nota
        builder.HasMany(aluno => aluno.Notas)
            .WithOne(nota =>nota.Aluno)
            .HasForeignKey(nota => nota.AlunoId);
    }
}