using Microsoft.EntityFrameworkCore;
using Dominio;

namespace DataAcess;

public class Contexto : DbContext
{
    public DbSet<Aluno> Aluno { get; set; }
    public DbSet<Curso> Curso { get; set; }
    public DbSet<Matricula> Matricula { get; set; }
    public DbSet<Nota> Nota { get; set; }
    public DbSet<Professor> Professor { get; set; }


    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=DESKTOP-58UEHOH\\SQLEXPRESS;Database=EscolaORM_Db;Trusted_Connection=True;TrustServerCertificate=True;"
        );
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AlunoConfiguration());
        modelBuilder.ApplyConfiguration(new CursoConfiguration());
        modelBuilder.ApplyConfiguration(new MatriculaConfiguration());
        modelBuilder.ApplyConfiguration(new NotaConfiguration());
        modelBuilder.ApplyConfiguration(new ProfessorConfiguration());
    }
}