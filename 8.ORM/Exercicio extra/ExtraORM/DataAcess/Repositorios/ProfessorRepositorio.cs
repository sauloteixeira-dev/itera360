using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;


using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using Microsoft.Identity.Client;

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

    //27. Some a carga horária total ministrada por cada professor
    public void CargaHorariaTotalPorProfessor()
    {
        var prof = _contexto.Professor
        .Include(c => c.Cursos)
        .ToList();

        foreach (var i in prof)
        {
            var cargaTotal = i.Cursos.Sum(c => c.CursoCargaHoraria);
            Console.WriteLine($"Nome: {i.ProfessorNome} - Carga Horaria: {cargaTotal}h");
        }
    }

    // 41. Criar tabela Turmas
    public void CriarTabelaTurmas()
    {
        _contexto.Database.ExecuteSqlRaw(@"
            CREATE TABLE Turmas (
            TurmaId INT IDENTITY(1,1) PRIMARY KEY,
            TurmaNome NVARCHAR(100) NOT NULL,
            TurmaAnoLetivo INT NOT NULL)
        ");
    }
    // 44. Criar tabela Departamentos
    public void CriarTabelaDepartamentos()
    {
        _contexto.Database.ExecuteSqlRaw(@"
        CREATE TABLE Departamentos (
            DepartamentoId INT IDENTITY(1,1) PRIMARY KEY,
            DepartamentoNome NVARCHAR(100) NOT NULL,
            ProfessorChefeId INT NOT NULL,
            FOREIGN KEY (ProfessorChefeId)
            REFERENCES Professor(ProfessorId)
        );
    ");
    }


    // 45. Remover tabela Departamentos
    public void RemoverTabelaDepartamentos()
    {
        _contexto.Database.ExecuteSqlRaw(
            "DROP TABLE Departamentos;"
        );
    }
    // 46. Remover tabela Turmas
    public void RemoverTabelaTurmas()
    {
        _contexto.Database.ExecuteSqlRaw(
            "DROP TABLE Turmas;"
        );
    }



}
