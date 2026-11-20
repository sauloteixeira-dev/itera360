namespace Dominio;

public class Curso
{
    public int CursoId { get; set; }
    public string CursoNome { get; set; }
    public int CursoCargaHoraria { get; set; }

    //FK
    public int ProfessorId { get; set; }
    public Professor Professor { get; set; }
}