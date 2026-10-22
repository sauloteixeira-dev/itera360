class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno("Maria", 20);
        Aluno aluno2 = new Aluno("João", 22);

        //classes staticas não precisam ser instanciadas
        RegistroEscolar.RegistrarAluno(aluno1);
        RegistroEscolar.RegistrarAluno(aluno2);

        System.Console.WriteLine("Total de alunos Registrados: " + RegistroEscolar.ContadorAlunos);
    }
}