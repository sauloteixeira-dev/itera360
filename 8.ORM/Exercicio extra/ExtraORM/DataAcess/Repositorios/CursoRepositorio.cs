using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

public class CursoRepositorio
{
    private readonly Contexto _contexto;
    public CursoRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    //6.	Liste os cursos com carga horária maior que 50 horas.
    public void MaisdeCinquentaHoras()
    {
        var MaisdeCinquenta = _contexto.Curso.Where(a => a.CursoCargaHoraria > 50);

        foreach (var item in MaisdeCinquenta)
        {
            Console.WriteLine($"Curso com mais de 50 Horas: {item.CursoNome}");
            Console.WriteLine($"Carga horária: {item.CursoCargaHoraria} horas");
            Console.WriteLine("----------------------");
        }
    }
    // public void ListarProfessoresPeloSalario()
    //     {
    //         var professores = _contexto.Professor
    //         .OrderByDescending(p => p.ProfessorSalario)
    //         .ToList();

    //         foreach (var prof in professores)
    //         {
    //             Console.WriteLine($"Nome: {prof.ProfessorNome} - Salario: {prof.ProfessorSalario}");
    //         }
    //     }
    //9.	Liste nome e carga horária dos cursos, ordenando da maior para a menor.
    public void CursoCargaHorariaMaiorMenor()
    {
        var cursos = _contexto.Curso.OrderByDescending(c => c.CursoCargaHoraria).ToList();
        foreach (var c in cursos)
        {
            Console.WriteLine($"Nome do Curso: {c.CursoNome} - Carga Horaria: {c.CursoCargaHoraria}h");
        }
    }
    //14.	Liste todos os cursos, incluindo os que não têm nenhum aluno matriculado.
    public void AllCursosIncludeNTemMatricula()
    {
        var cursos = _contexto.Curso
     .Include(c => c.Matriculas)
     .ThenInclude(m => m.Aluno)
     .ToList();

        foreach (var curso in cursos)
        {
            Console.WriteLine($"Curso: {curso.CursoNome}");

            if (curso.Matriculas.Any())
            {
                foreach (var matricula in curso.Matriculas)
                {
                    Console.WriteLine($"Aluno: {matricula.Aluno.AlunoNome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno matriculado neste curso.");
            }
        }
    }


    // 17. Para cada curso, mostre o professor responsável e os alunos matriculados.
    public void CursoProfessorAlunos()
    {
        var cursos = _contexto.Curso
            .Include(c => c.Professor)
            .Include(c => c.Matriculas)
                .ThenInclude(m => m.Aluno)
            .ToList();

        foreach (var curso in cursos)
        {
            Console.WriteLine($"Curso: {curso.CursoNome}");
            Console.WriteLine($"Professor: {curso.Professor.ProfessorNome}");

            if (curso.Matriculas.Any())
            {
                foreach (var matricula in curso.Matriculas)
                {
                    Console.WriteLine($"Aluno: {matricula.Aluno.AlunoNome}");
                }
            }
            else
            {
                Console.WriteLine("Nenhum aluno matriculado.");
            }

            Console.WriteLine("-------------------------");
        }
    }
    //23.	Conte quantos cursos existem no total.
    public void QtdCursos()
    {
        var qtd = _contexto.Curso.Count();

        Console.WriteLine($"A quantidade de cursos é de: {qtd}");
    }

    //25.	Calcule a média das notas de cada curso.
    public void MediaDeNotas()
    {
        var m = _contexto.Curso
        .Select(c => new
        {
            Curso = c.CursoNome,
            Media = c.Notas.Average(n => n.NotaNota)
        }).ToList();

        foreach (var i in m)
        {
            Console.WriteLine($"Curso: {i.Curso} - Média: {i.Media:F2}");
        }
    }





}