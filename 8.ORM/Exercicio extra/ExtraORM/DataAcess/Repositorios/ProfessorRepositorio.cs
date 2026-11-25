using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

public class ProfessorRepositorio
{
    private readonly Contexto _contexto;
    public ProfessorRepositorio(Contexto contexto)
    {
        _contexto = contexto;
    }

    //7.	Liste os professores ordenados pelo salário de forma decrescente.
    public void ListarProfessoresPeloSalario()
    {
        var professores = _contexto.Professor
        .OrderByDescending(p => p.ProfessorSalario)
        .ToList();

        foreach (var prof in professores)
        {
            Console.WriteLine($"Nome: {prof.ProfessorNome} - Salario: {prof.ProfessorSalario}");
        }
    }
    //8.	Retorne nome e especialidade dos professores com salário acima de 5000.
    public void ProfessoresEspecMaisCincoMil()
    {
        var professores = _contexto.Professor
        .Where(p => p.ProfessorSalario >= 5000)
        .ToList();

        foreach (var prof in professores)
        {
            Console.WriteLine($"Nome: {prof.ProfessorNome} - Salario: {prof.ProfessorSalario} - Especialidade: {prof.ProfessorEspecialidade}");
        }
    }
    //12.	Liste todos os cursos junto com o nome do respectivo professor.
    public void CursosProfessor()
    {
        var p = _contexto.Curso
        .Include(p => p.Professor)
        .ToList();

        foreach (var prof in p)
        {
            Console.WriteLine($"Curso: {prof.CursoNome} - Professor: {prof.Professor.ProfessorNome}");
        }
    }
    /*public void IdadeMediaAlunos()
        {
            var count = _contexto.Aluno.Average(a => a.AlunoIdade);

        Console.WriteLine($"A média de Idade dos Alunos: {count:F2}");
        }*/

    //21.	Calcule o salário médio dos professores.
    public void SalarioMedioProfessores()
    {
        var count = _contexto.Professor.Average(p => p.ProfessorSalario);

        Console.WriteLine($"A média salarial dos professores é de : {count:C2}");
    }
    //22.	Encontre o menor e o maior salário entre os professores.
    public void MinMaxSalarioProfess()
    {
        var min = _contexto.Professor.Min(s => s.ProfessorSalario);
        var max = _contexto.Professor.Max(s => s.ProfessorSalario);

        Console.WriteLine($"O Menor Salario é: {min:C2} e o Maior é: {max:C2}");
    }


}
