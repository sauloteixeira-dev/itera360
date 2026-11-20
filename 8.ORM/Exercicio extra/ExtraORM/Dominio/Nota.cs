namespace Dominio;

public class Nota
{
    public int NotaId { get; set; }
    public decimal NotaNota { get; set; }
    public DateTime NotaDataLancamento { get; set; }

    //FK
    public int AlunoId { get; set; }
    public Aluno Aluno { get; set; }

    //FK
    public int CursoId { get; set; }
    public Curso Curso { get; set; }
}