using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class ProfessorConfiguration : IEntityTypeConfiguration<Professor>
{
    public void Configure(EntityTypeBuilder<Professor> builder)
    {
        // Tabela e chave primária
        builder.ToTable("Professor");
        builder.HasKey(professor=>professor.ProfessorId);

        // Propriedades
        builder.Property(professor=>professor.ProfessorId)
            .HasColumnName("ProfessorId");

        builder.Property(professor=>professor.ProfessorNome)
            .HasColumnName("ProfessorNome");

        builder.Property(professor=>professor.ProfessorIdade)
            .HasColumnName("ProfessorIdade");

        builder.Property(professor=>professor.ProfessorSalario)
            .HasColumnName("ProfessorSalario")
            .HasPrecision(18, 2);

        builder.Property(professor=>professor.ProfessorEspecialidade)
            .HasColumnName("ProfessorEspecialidade");

        // Relacionamento 1:N com Curso
        builder.HasMany(professor=>professor.Cursos)
            .WithOne(curso=>curso.Professor)
            .HasForeignKey(curso=>curso.ProfessorId);
    }
}