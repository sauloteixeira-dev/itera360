using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;

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
                Console.WriteLine($"ID: {aluno.AlunoId}");
            Console.WriteLine($"Nome: {aluno.AlunoNome}");
            Console.WriteLine($"Idade: {aluno.AlunoIdade}");
            Console.WriteLine("----------------------");
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

    //6. continua em cursosRepositorio
    //-------------------------------------------------------------------


}