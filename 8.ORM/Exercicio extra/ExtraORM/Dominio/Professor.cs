namespace Dominio;

public class Professor
{
    public int ProfessorId { get; set; }
    public string ProfessorNome { get; set; }
    public int ProfessorIdade { get; set; }
    public decimal ProfessorSalario { get; set; }
    public string ProfessorEspecialidade { get; set; }
    public string ProfessorEmail { get; set; }

    // Relacionamento 1:N com Curso
    public ICollection<Curso> Cursos { get; set; }
        = new List<Curso>();
}