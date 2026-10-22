public static class RegistroEscolar
{
    private static int contadorAlunos;
    public static int ContadorAlunos
    {
        get
        { return contadorAlunos; }
    }

    static RegistroEscolar()
    {
        contadorAlunos = 0;
    }

    public static void RegistrarAluno(Aluno aluno)
    {
        contadorAlunos++;
    }
}