using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.ComponentModel;

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

    //28.	Encontre o curso com a maior média de notas.

    public void MaiorMediaNotas()
    {
        var curso = _contexto.Curso
        .Include(c => c.Notas)
        .ToList()
        .Where(c => c.Notas.Any())
        .Select(c => new
        {
            Curso = c,
            Media = c.Notas.Average(n => n.NotaNota)
        }).OrderByDescending(c => c.Media)
        .FirstOrDefault();
        if (curso != null)
        {
            Console.WriteLine($"Curso: {curso.Curso.CursoNome} - Maior média: {curso.Media:F2}");
        }

    }
    //29.	Calcule a média geral de todas as notas do sistema.
    public void mediaGeralNotas()
    {
        var m = _contexto.Nota.Average(n => n.NotaNota);

        Console.WriteLine($"Media geral : {m:F2}");
    }

    //32.	Insira um novo curso chamado "Banco de Dados", 80h de carga horária, ministrado por "João Pereira".
    public void InserirNovoCurso()
    {
        var professor = _contexto.Professor.FirstOrDefault(p => p.ProfessorNome == "João Pereira");

        if (professor == null)
        {
            professor = new Professor
            {
                ProfessorNome = "João Pereira"
            };
            _contexto.Professor.Add(professor);
        }

        var curso = new Curso
        {
            CursoNome = "Banco de Dados",
            CursoCargaHoraria = 80,
            Professor = professor
        };
        _contexto.Curso.Add(curso);
        _contexto.SaveChanges();

        Console.WriteLine("Curso Cadastrado com Sucesso");
    }

    //33.	Aumente o salário de todos os professores em 10%.
    public void AumentarSalario()
    {
        var professores = _contexto.Professor.ToList();

        foreach (var professor in professores)
        {
            professor.ProfessorSalario *= 1.10m;
        }

        _contexto.SaveChanges();

        Console.WriteLine("Salários atualizados com sucesso!");
    }

    //39. Atualize História do Brasil para 60h
    public void AtualizarCargaHoraria()
    {
        var curso = _contexto.Curso
            .FirstOrDefault(c => c.CursoNome == "História do Brasil");

        if (curso != null)
        {
            curso.CursoCargaHoraria = 60;

            _contexto.SaveChanges();

            Console.WriteLine("Carga horária atualizada!");
        }
        else
        {
            Console.WriteLine("Curso não encontrado!");
        }
    }

    //40. Remova Lógica de Programação (cuidado com dependências)
    public void RemoverCurso()
    {
        var curso = _contexto.Curso
            .Include(c => c.Notas)
            .FirstOrDefault(c => c.CursoNome == "Lógica de Programação");

        if (curso == null)
        {
            Console.WriteLine("Curso não encontrado!");
            return;
        }

        _contexto.Nota.RemoveRange(curso.Notas);

        _contexto.Curso.Remove(curso);

        _contexto.SaveChanges();

        Console.WriteLine("Curso removido com sucesso!");
    }

    //41.	Crie uma nova entidade Turmas com os campos: Id, NomeTurma, AnoLetivo.
    
}