using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Headers;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Storage;

public class AlunoRepositorio
{
    private readonly Contexto _contexto;
    public AlunoRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    //1. Liste todos os alunos cadastrados.
    public void MostrarTodosAlunos()
    {
        var alunos = _contexto.Aluno.ToList();

        foreach (var aluno in alunos)
        {
            Console.WriteLine($"ID: {aluno.AlunoId}");
            Console.WriteLine($"Nome: {aluno.AlunoNome}");
            Console.WriteLine($"Idade: {aluno.AlunoIdade}");
            Console.WriteLine("----------------------");
        }
    }

    //2.	Retorne nome e idade dos alunos com mais de 18 anos.
    public void MostrarAlunosMaiores()
    {
        var alunos = _contexto.Aluno.ToList();

        foreach (var aluno in alunos)
        {
            if (aluno.AlunoIdade >= 18)
            {
                Console.WriteLine($"ID: {aluno.AlunoId}");
                Console.WriteLine($"Nome: {aluno.AlunoNome}");
                Console.WriteLine($"Idade: {aluno.AlunoIdade}");
                Console.WriteLine("----------------------");
            }
        }
    }

    //3.	Liste os nomes das cidades dos alunos sem repetição (Distinct).
    public void CidadesDosAlunosSemRepetir()
    {
        var cidades = _contexto.Aluno
            .Select(a => a.AlunoCidade)
            .Distinct()
            .ToList();

        foreach (var cidade in cidades)
        {
            Console.WriteLine(cidade);
        }
    }

    //4.	Retorne os 5 alunos mais novos (OrderBy + Take).
    public void AlunosMaisNovos()
    {
        var novos = _contexto.Aluno
        .OrderBy(i => i.AlunoIdade)
        .Take(5)
        .ToList();
        foreach (var aluno in novos)
        {
            Console.WriteLine($"Nome: {aluno.AlunoNome} - Idade: {aluno.AlunoIdade}");
        }
    }

    //5.	Retorne nome, idade e cidade dos alunos do estado "SP".
    public void AlunosDeSp()
    {
        var deSp = _contexto.Aluno
            .Where(a => a.AlunoEstado == "SP")
            .Select(a => new
            {
                a.AlunoNome,
                a.AlunoIdade,
                a.AlunoCidade
            })
            .ToList();
        foreach (var aluno in deSp)
        {
            Console.WriteLine($"Nome: {aluno.AlunoNome} | Idade: {aluno.AlunoIdade} | Cidade: {aluno.AlunoCidade}");
        }
    }

    //10.	Retorne nome e idade dos alunos nascidos depois de 2006.
    public void AlunosNascidosPos()
    {
        var DepoisDe2006 = _contexto.Aluno.Where(a => a.AlunoDataNascimento.Year > 2006).ToList();

        foreach (var doisMilESeis in DepoisDe2006)
        {
            Console.WriteLine($"Nome: {doisMilESeis.AlunoNome} - Ano Nascimento: {doisMilESeis.AlunoDataNascimento.Year}");
        }
    }

    //13.	Liste todos os alunos, incluindo os que não estão matriculados em nenhum curso.
    public void AllAlunos()
    {
        var alunos = _contexto.Aluno
        .Include(a => a.Matriculas)
        .ThenInclude(m => m.Curso)
        .ToList();

        foreach (var all in alunos)
        {
            Console.WriteLine($"Nome: {all.AlunoNome} ");
            if (all.Matriculas.Any())
            {
                foreach (var a in all.Matriculas)
                {
                    Console.WriteLine($"Curso: {a.Curso.CursoNome}");
                }
            }
            else
            {
                Console.WriteLine("Não está matriculado em nenhum curso.");
            }
        }

    }
    // 15. Monte uma lista combinando alunos e cursos, contemplando também os casos sem correspondência.
    public void ListAlunoCursos()
    {
        var alunos = _contexto.Aluno
            .Include(a => a.Matriculas)
            .ThenInclude(m => m.Curso)
            .ToList();

        var cursos = _contexto.Curso
            .Include(c => c.Matriculas)
            .ThenInclude(m => m.Aluno)
            .ToList();

        var resultado = alunos
            .SelectMany(a => a.Matriculas.DefaultIfEmpty(),
                (a, m) => new
                {
                    Aluno = a.AlunoNome,
                    Curso = m?.Curso?.CursoNome
                })
            .Concat(
                cursos
                    .Where(c => !c.Matriculas.Any())
                    .Select(c => new
                    {
                        Aluno = (string)null,
                        Curso = c.CursoNome
                    })
            );

        foreach (var item in resultado)
        {
            Console.WriteLine($"Aluno: {item.Aluno ?? "Sem aluno"} - Curso: {item.Curso ?? "Sem curso"}");
        }
    }

    //16.	Mostre nome do aluno, nome do curso e a nota obtida, unindo Alunos, Cursos e Notas.
    public void AlunoCursoNota()
    {
        var resultado = _contexto.Nota
        .Include(n => n.Aluno)
        .Include(n => n.Curso)
        .ToList();

        foreach (var nota in resultado)
        {
            Console.WriteLine($"Nome: {nota.Aluno.AlunoNome} - Curso: {nota.Curso.CursoNome} - Nota: {nota.NotaNota}");
        }
    }

    //18.	Liste o nome de cada aluno junto com o nome do professor dos cursos em que ele está matriculado.
    public void NomeAlunoMatriculado()
    {
        var a = _contexto.Matricula
        .Include(a => a.Aluno)
        .Include(a => a.Curso)
        .ThenInclude(b => b.Professor)
        .ToList();

        foreach (var i in a)
        {
            Console.WriteLine($"Nome Aluno: {i.Aluno.AlunoNome} - Nome Professor: {i.Curso.Professor.ProfessorNome}");
        }
    }

    //19.	Conte quantos alunos existem no total.
    public void ContaAluno()
    {
        var count = _contexto.Aluno.Count();

        Console.WriteLine($"Total de Alunos: {count}");
    }

    //20.	Calcule a média de idade dos alunos.
    public void IdadeMediaAlunos()
    {
        var count = _contexto.Aluno.Average(a => a.AlunoIdade);

        Console.WriteLine($"A média de Idade dos Alunos: {count:F2}");
    }

    //26.	Mostre a quantidade de alunos agrupados por estado.
    public void qtdAlunosPorEstado()
    {
        var alunosPorEstado = _contexto.Aluno
        .GroupBy(a => a.AlunoEstado)
        .Select(g => new
        {
            Estado = g.Key,
            Quantidade = g.Count()
        }).ToList();

        foreach (var o in alunosPorEstado)
        {
            Console.WriteLine($"Estado: {o.Estado} - Quantidade de Alunos: {o.Quantidade}");
        }
    }

    //30.	Encontre o aluno com a maior nota registrada.
    public void AlunoMaiorNota()
    {
        var a = _contexto.Aluno
        .SelectMany(a => a.Notas, (aluno, nota) => new
        {
            Aluno = aluno,
            Nota = nota.NotaNota
        })
        .OrderByDescending(c => c.Nota)
        .FirstOrDefault();

        if (a != null)
        {
            Console.WriteLine($"Aluno: {a.Aluno.AlunoNome}");
            Console.WriteLine($"Maior nota: {a.Nota}");
        }

    }

    //31.	Insira um novo aluno chamado "Maria Silva", 17 anos, cidade de Salvador (BA).
    public void InserirAluno()
    {
        var aluno = new Aluno
        {
            AlunoNome = "Maria Silva",
            AlunoIdade = 17,
            AlunoCidade = "Salvador",
            AlunoEstado = "BA"
        };

        _contexto.Aluno.Add(aluno);

        _contexto.SaveChanges();

        Console.WriteLine("Aluno cadastrado com sucesso!");
    }

    //34. Atualizar a cidade dos alunos do estado SP
    public void AtualizarCidade()
    {
        var alunos = _contexto.Aluno
            .Where(a => a.AlunoEstado == "SP")
            .ToList();

        foreach (var aluno in alunos)
        {
            aluno.AlunoCidade = "São Paulo (Capital)";
        }

        _contexto.SaveChanges();

        Console.WriteLine("Cidades atualizadas com sucesso!");
    }
    //35. Atualizar a nota de Lucas Almeida no curso Matemática Básica
    public void AtualizarNota()
    {
        var nota = _contexto.Nota
            .Include(n => n.Aluno)
            .Include(n => n.Curso)
            .FirstOrDefault(n =>
                n.Aluno.AlunoNome == "Lucas Almeida" &&
                n.Curso.CursoNome == "Matemática Básica"
            );

        if (nota != null)
        {
            nota.NotaNota = 9.5m;

            _contexto.SaveChanges();

            Console.WriteLine("Nota atualizada com sucesso!");
        }
        else
        {
            Console.WriteLine("Nota não encontrada!");
        }
    }

    //36. Remova todas as notas menores que 6.0
    public void RemoverNotasBaixas()
    {
        var notas = _contexto.Nota
            .Where(n => n.NotaNota < 6.0m)
            .ToList();

        _contexto.Nota.RemoveRange(notas);

        _contexto.SaveChanges();

        Console.WriteLine("Notas removidas com sucesso!");
    }

    //37. Remova todos os alunos que não possuem nenhuma matrícula
    public void RemoverAlunosSemMatricula()
    {
        var alunos = _contexto.Aluno
            .Where(a => !a.Matriculas.Any())
            .ToList();

        _contexto.Aluno.RemoveRange(alunos);

        _contexto.SaveChanges();

        Console.WriteLine("Alunos removidos com sucesso!");
    }

    //38. Insira uma nova nota para Fernanda Costa no curso Gramática Avançada
    public void InserirNovaNota()
    {
        var aluno = _contexto.Aluno
            .FirstOrDefault(a => a.AlunoNome == "Fernanda Costa");

        var curso = _contexto.Curso
            .FirstOrDefault(c => c.CursoNome == "Gramática Avançada");

        if (aluno == null || curso == null)
        {
            Console.WriteLine("Aluno ou curso não encontrado!");
            return;
        }

        var nota = new Nota
        {
            NotaNota = 8.0m,
            Aluno = aluno,
            Curso = curso
        };

        _contexto.Nota.Add(nota);
        _contexto.SaveChanges();

        Console.WriteLine("Nota cadastrada com sucesso!");
    }






}