using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class MatriculaConfiguration : IEntityTypeConfiguration<Matricula>
{
    public void Configure(EntityTypeBuilder<Matricula> builder)
    {
        // Tabela e chave primária
        builder.ToTable("Matricula");
        builder.HasKey(matricula => matricula.MatriculaId);

        // Propriedades
        builder.Property(matricula => matricula.MatriculaId)
            .HasColumnName("MatriculaId");

        builder.Property(matricula => matricula.MatriculaDataMatricula)
            .HasColumnName("DataMatricula");

        // Relacionamento 1:N com Aluno
        builder.HasOne(matricula => matricula.Aluno)
            .WithMany(aluno => aluno.Matriculas)
            .HasForeignKey(matricula => matricula.AlunoId);

        // Relacionamento 1:N com Curso
        builder.HasOne(matricula => matricula.Curso)
            .WithMany(curso => curso.Matriculas)
            .HasForeignKey(matricula => matricula.CursoId);
    }
}