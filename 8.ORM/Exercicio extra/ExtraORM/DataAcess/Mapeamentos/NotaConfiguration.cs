using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class NotaConfiguration : IEntityTypeConfiguration<Nota>
{
    public void Configure(EntityTypeBuilder<Nota> builder)
    {
        // Tabela e chave primária
        builder.ToTable("Nota");
        builder.HasKey(nota => nota.NotaId);

        // Propriedades
        builder.Property(nota => nota.NotaId)
            .HasColumnName("NotaId");

        builder.Property(nota => nota.NotaNota)
            .HasColumnName("NotaNota")
            .HasPrecision(18, 2);

        builder.Property(nota => nota.NotaDataLancamento)
            .HasColumnName("NotaDataLancamento");

        // Relacionamento 1:N com Aluno
        builder.HasOne(nota => nota.Aluno)
            .WithMany(aluno => aluno.Notas)
            .HasForeignKey(nota => nota.AlunoId);

        // Relacionamento 1:N com Curso
        builder.HasOne(nota => nota.Curso)
            .WithMany(curso => curso.Notas)
            .HasForeignKey(nota => nota.CursoId);
    }
}