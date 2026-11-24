namespace Dominio;

public class Aluno
{
    public int AlunoId { get; set; }
    public string AlunoNome { get; set; }
    public int AlunoIdade { get; set; }
    public DateTime AlunoDataNascimento { get; set; }
    public string AlunoCidade { get; set; }
    public string AlunoEstado { get; set; }

    // Relacionamento 1:N com Matricula
    public ICollection<Matricula> Matriculas { get; set; }
        = new List<Matricula>();

    // Relacionamento 1:N com Nota
    public ICollection<Nota> Notas { get; set; }
        = new List<Nota>();
}