using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class CursoConfiguration : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        // Tabela e chave primária
        builder.ToTable("Curso");
        builder.HasKey(curso => curso.CursoId);

        // Propriedades
        builder.Property(curso => curso.CursoId)
            .HasColumnName("CursoId");

        builder.Property(curso => curso.CursoNome)
            .HasColumnName("CursoNome");

        builder.Property(curso => curso.CursoCargaHoraria)
            .HasColumnName("CursoCargaHoraria");

        // Relacionamento 1:N com Professor
        builder.HasOne(curso => curso.Professor)
            .WithMany(professor => professor.Cursos)
            .HasForeignKey(curso => curso.ProfessorId);

        // Relacionamento 1:N com Matricula
        builder.HasMany(curso => curso.Matriculas)
            .WithOne(matricula => matricula.Curso)
            .HasForeignKey(matricula => matricula.CursoId);

        // Relacionamento 1:N com Nota
        builder.HasMany(curso => curso.Notas)
            .WithOne(nota=>nota.Curso)
            .HasForeignKey(nota=>nota.CursoId);
    }
}