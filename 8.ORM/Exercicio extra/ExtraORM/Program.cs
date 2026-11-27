using DataAcess;
using Dominio;
public partial class Program
{
    public static void Main(string[] args)
    {
        using (var contexto = new Contexto())
        {

            var alunoRepo = new AlunoRepositorio(contexto);
            var cursoRepo = new CursoRepositorio(contexto);
            var professorRepo = new ProfessorRepositorio(contexto);
            var matriculaRepo = new MatriculaRepositorio(contexto);

            int opcao;

            do
            {
                Console.WriteLine("\n========== MENU DE EXERCÍCIOS ORM ==========");
                Console.WriteLine("Digite o número do exercício (0 para sair):");

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Digite um número válido!");
                    continue;
                }

                switch (opcao)
                {
                    // ALUNO
                    case 1:
                        alunoRepo.MostrarTodosAlunos();
                        break;

                    case 2:
                        alunoRepo.MostrarAlunosMaiores();
                        break;

                    case 3:
                        alunoRepo.CidadesDosAlunosSemRepetir();
                        break;

                    case 4:
                        alunoRepo.AlunosMaisNovos();
                        break;

                    case 5:
                        alunoRepo.AlunosDeSp();
                        break;

                    // CURSO
                    case 6:
                        cursoRepo.MaisdeCinquentaHoras();
                        break;

                    // PROFESSOR
                    case 7:
                        professorRepo.ListarProfessoresPeloSalario();
                        break;

                    case 8:
                        professorRepo.ProfessoresEspecMaisCincoMil();
                        break;

                    // CURSO
                    case 9:
                        cursoRepo.CursoCargaHorariaMaiorMenor();
                        break;

                    // ALUNO
                    case 10:
                        alunoRepo.AlunosNascidosPos();
                        break;

                    // MATRICULA
                    case 11:
                        matriculaRepo.MatriculaNomeCurso();
                        break;

                    // PROFESSOR
                    case 12:
                        professorRepo.CursosProfessor();
                        break;

                    // ALUNO
                    case 13:
                        alunoRepo.AllAlunos();
                        break;

                    // CURSO
                    case 14:
                        cursoRepo.AllCursosIncludeNTemMatricula();
                        break;

                    // ALUNO
                    case 15:
                        alunoRepo.ListAlunoCursos();
                        break;

                    case 16:
                        alunoRepo.AlunoCursoNota();
                        break;

                    // CURSO
                    case 17:
                        cursoRepo.CursoProfessorAlunos();
                        break;

                    // ALUNO
                    case 18:
                        alunoRepo.NomeAlunoMatriculado();
                        break;

                    case 19:
                        alunoRepo.ContaAluno();
                        break;

                    case 20:
                        alunoRepo.IdadeMediaAlunos();
                        break;

                    // PROFESSOR
                    case 21:
                        professorRepo.SalarioMedioProfessores();
                        break;

                    case 22:
                        professorRepo.MinMaxSalarioProfess();
                        break;

                    // CURSO
                    case 23:
                        cursoRepo.QtdCursos();
                        break;

                    // MATRICULA
                    case 24:
                        matriculaRepo.AgruparMatriculasCursos();
                        break;

                    // CURSO
                    case 25:
                        cursoRepo.MediaDeNotas();
                        break;

                    // ALUNO
                    case 26:
                        alunoRepo.qtdAlunosPorEstado();
                        break;

                    // PROFESSOR
                    case 27:
                        professorRepo.CargaHorariaTotalPorProfessor();
                        break;

                    // CURSO
                    case 28:
                        cursoRepo.MaiorMediaNotas();
                        break;

                    case 29:
                        cursoRepo.mediaGeralNotas();
                        break;

                    // ALUNO
                    case 30:
                        alunoRepo.AlunoMaiorNota();
                        break;

                    case 31:
                        alunoRepo.InserirAluno();
                        break;

                    // CURSO
                    case 32:
                        cursoRepo.InserirNovoCurso();
                        break;

                    case 33:
                        cursoRepo.AumentarSalario();
                        break;

                    // ALUNO
                    case 34:
                        alunoRepo.AtualizarCidade();
                        break;

                    case 35:
                        alunoRepo.AtualizarNota();
                        break;

                    case 36:
                        alunoRepo.RemoverNotasBaixas();
                        break;

                    case 37:
                        alunoRepo.RemoverAlunosSemMatricula();
                        break;

                    case 38:
                        alunoRepo.InserirNovaNota();
                        break;

                    // CURSO
                    case 39:
                        cursoRepo.AtualizarCargaHoraria();
                        break;

                    case 40:
                        cursoRepo.RemoverCurso();
                        break;

                    // PROFESSOR - TABELAS
                    case 41:
                        professorRepo.CriarTabelaTurmas();
                        break;

                    case 44:
                        professorRepo.CriarTabelaDepartamentos();
                        break;

                    case 45:
                        professorRepo.RemoverTabelaDepartamentos();
                        break;

                    case 46:
                        professorRepo.RemoverTabelaTurmas();
                        break;

                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;

                    default:
                        Console.WriteLine("Exercício não encontrado!");
                        break;
                }

                if (opcao != 0)
                {
                    Console.WriteLine("\nPressione ENTER para continuar...");
                    Console.ReadLine();
                }

            } while (opcao != 0);
        }
    }
}