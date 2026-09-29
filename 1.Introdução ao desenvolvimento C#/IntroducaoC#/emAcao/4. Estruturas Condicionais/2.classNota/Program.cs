int nota;
string classif;

Console.WriteLine("Informe a nota do aluno: ");
nota = int.Parse(Console.ReadLine());

if (nota >= 90)
{
    classif = "A";
}
else if (nota >= 80 && nota < 90)
{
    classif = "B";
}
else if (nota >= 70 && nota < 80)
{
    classif = "C";
}
else if (nota >= 60 && nota < 70)
{
    classif = "D";
}else{
    classif = "F";
}

Console.WriteLine($"A nota: {nota}, tem a classificação: {classif}");