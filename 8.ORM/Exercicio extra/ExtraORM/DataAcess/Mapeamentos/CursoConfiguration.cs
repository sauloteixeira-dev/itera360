using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Dominio;

namespace DataAcess;

public class CursoConfiguration : IEntityTypeConfiguration<Curso>
{
    public void Configure(EntityTypeBuilder<Curso> builder)
    {
        builder.ToTable("Aluno").HasKey(curso => curso.CursoId);

        builder.Property(Curso => Curso.CursoId).HasColumnName("CursoId");
        builder.Property(Curso => Curso.CursoNome).HasColumnName("CursoNome");
        builder.Property(Curso => Curso.CursoCargaHoraria).HasColumnName("CursoCargaHoraria");
        builder.Property(Curso => Curso.ProfessorId).HasForeingKey("ProfessorId");

    }
}