using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

using DataAcess;
using Dominio;
using Microsoft.EntityFrameworkCore;

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
}