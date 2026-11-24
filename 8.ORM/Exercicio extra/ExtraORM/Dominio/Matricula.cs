namespace Dominio;

public class Matricula
{
    public int MatriculaId { get; set; }
    public DateTime MatriculaDataMatricula { get; set; }

    // FK - Aluno
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    // FK - Curso
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
}