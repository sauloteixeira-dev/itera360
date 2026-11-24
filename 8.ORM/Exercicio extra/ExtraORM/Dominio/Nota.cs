namespace Dominio;

public class Nota
{
    public int NotaId { get; set; }
    public decimal NotaNota { get; set; }
    public DateTime NotaDataLancamento { get; set; }

    // FK - Aluno
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    // FK - Curso
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
}