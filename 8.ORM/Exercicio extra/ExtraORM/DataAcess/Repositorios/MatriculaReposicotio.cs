
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

public class MatriculaRepositorio
{
    private readonly Contexto _contexto;
    public MatriculaRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    //11.	Para cada matrícula, mostre o nome do aluno e o nome do curso correspondente.
    public void MatriculaNomeCurso()
    {
        var MatNomeCurso = _contexto.Matricula
        .Include(m => m.Aluno)
        .Include(m => m.Curso)
        .ToList();

        foreach (var m in MatNomeCurso)
        {
            Console.WriteLine($"Matricula: {m.MatriculaId} - Aluno: {m.Aluno.AlunoNome} - Curso {m.Curso.CursoNome}");
        }
    }

    // 24. Agrupe as matrículas por curso e mostre quantos alunos há em cada um.
    public void AgruparMatriculasCursos()
    {
        var matAgroup = _contexto.Matricula
            .GroupBy(m => m.Curso.CursoNome)
            .Select(g => new
            {
                Curso = g.Key,
                QuantidadeAlunos = g.Count()
            })
            .ToList();

        foreach (var item in matAgroup)
        {
            Console.WriteLine($"Curso: {item.Curso} - Quantidade de alunos: {item.QuantidadeAlunos}");
        }
    }





}

