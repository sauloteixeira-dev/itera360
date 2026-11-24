namespace Dominio;

public class Curso
{
    public int CursoId { get; set; }
    public string CursoNome { get; set; }
    public int CursoCargaHoraria { get; set; }

    // FK - Professor
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }

    // Relacionamento 1:N com Matricula
    public ICollection<Matricula> Matriculas { get; set; }
        = new List<Matricula>();

    // Relacionamento 1:N com Nota
    public ICollection<Nota> Notas { get; set; }
        = new List<Nota>();
}