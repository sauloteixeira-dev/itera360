--Consultas Básicas (SELECT, WHERE, ORDER BY,DISTINCT, TOP)--

--1-Liste todos os alunos cadastrados
SELECT * FROM Alunos;

--2-Mostre o nome e a idade dos alunos que têm mais de 18 anos.
SELECT * FROM Alunos WHERE Idade>18;

--3-Liste os nomes das cidades dos alunos sem repetir (use DISTINCT).
SELECT DISTINCT Cidade FROM Alunos;

--4-Exiba os 5 alunos mais novos (TOP e ORDER BY).
SELECT TOP 5
	NomeAluno,Idade
FROM Alunos
ORDER BY Idade ASC;

--5-Mostre nome, idade e cidade dos alunos do estado de “SP”.
SELECT nomeAluno, Idade, Cidade FROM Alunos WHERE Estado = 'SP';

--6-Liste os cursos com carga horária maior que 50 horas.
SELECT NomeCurso, CargaHoraria FROM Cursos WHERE CargaHoraria > 50;

--7-Exiba os professores ordenados pelo salário decrescente.
SELECT NomeProfessor, SalarioProfessor FROM Professores ORDER BY SalarioProfessor DESC;

--8-Mostre o nome e especialidade dos professores com salário acima de 5000.
SELECT
	NomeProfessor, EspecialidadeProfessor, SalarioProfessor 
FROM
	Professores 
WHERE 
	SalarioProfessor > 5000 
ORDER BY 
	SalarioProfessor 
ASC;

--9-Liste os nomes dos cursos e a carga horária, ordenando da maior para a menor.
SELECT NomeCurso, CargaHoraria FROM Cursos ORDER BY CargaHoraria DESC;

--10-Mostre o nome e a idade dos alunos que nasceram depois de 2006.
SELECT NomeAluno, Idade,DataNascimento FROM Alunos WHERE DataNascimento > '2006-12-31';






-- Junções (INNER, LEFT, RIGHT, FULL JOIN)--

--11-Mostre o nome do aluno e o nome do curso em que ele está matriculado (INNER JOIN).
SELECT NomeAluno, NomeCurso FROM Alunos 
INNER JOIN Matriculas ON Alunos.IdAluno = Matriculas.IdAluno 
INNER JOIN Cursos ON Cursos.IdCurso = Matriculas.IdCurso
ORDER BY NomeAluno;

--12- Liste todos os cursos e seus respectivos professores (INNER JOIN).
SELECT NomeCurso, NomeProfessor FROM Cursos
INNER JOIN Professores ON Cursos.IdProfessor = Professores.IdProfessor
ORDER BY NomeProfessor ASC;

--13-Exiba todos os alunos, mesmo os que não estão matriculados em nenhum curso (LEFT JOIN).
SELECT NomeAluno, DataMatricula FROM Alunos
LEFT JOIN Matriculas ON Alunos.IdAluno = Matriculas.IdAluno
ORDER BY
	NomeAluno ASC;

--14-Exiba todos os cursos, mesmo aqueles sem alunos matriculados (RIGHT JOIN)
SELECT nomeCurso, DataMatricula FROM Matriculas
RIGHT JOIN Cursos ON Cursos.IdCurso = Matriculas.IdCurso;

--15-Mostre uma lista completa de alunos e cursos, incluindo os que não possuem correspondência (FULL JOIN).
SELECT 
    Alunos.NomeAluno, 
    Cursos.NomeCurso
FROM Alunos
FULL OUTER JOIN Matriculas
    ON Alunos.IdAluno = Matriculas.IdAluno
FULL OUTER JOIN Cursos
	ON Matriculas.IdCurso = Cursos.IdCurso
ORDER BY NomeAluno;

--16- Mostre o nome do aluno, curso e nota obtida (INNER JOIN entre Alunos, Cursos e Notas).
SELECT 
	NomeAluno,
	NomeCurso,
	Nota
FROM Notas
INNER JOIN Cursos
	ON Notas.IdCurso = Cursos.IdCurso
INNER JOIN Alunos
	ON Alunos.IdAluno = Notas.IdAluno
ORDER BY Notas.Nota ASC;

--17-Exiba o professor responsável e os alunos matriculados em cada curso (JOIN entre Professores, Cursos e Alunos).
SELECT
	NomeProfessor,
	NomeCurso,
	NomeAluno
FROM Professores
INNER JOIN Cursos
	ON Professores.IdProfessor = Cursos.IdProfessor
INNER JOIN Matriculas
	ON Cursos.IdCurso = Matriculas.IdCurso
INNER JOIN Alunos
	ON Alunos.IdAluno = Matriculas.IdAluno
ORDER BY NomeProfessor ASC;

--18-Liste os nomes dos alunos e seus professores correspondentes (usando múltiplos JOINs).
SELECT 
	NomeAluno,
	NomeProfessor
FROM Professores
INNER JOIN Cursos
	ON Cursos.IdProfessor = Professores.IdProfessor
INNER JOIN Matriculas
	ON Cursos.IdCurso = Matriculas.IdCurso
INNER JOIN Alunos
	ON Matriculas.IdAluno = Alunos.IdAluno
ORDER BY NomeAluno ASC;

--Funções de Agregação e Agrupamento (COUNT,SUM, AVG, MIN, MAX, GROUP BY)
--19-Conte quantos alunos existem na tabela Alunos
SELECT COUNT(IdAluno) AS qtdAlunos FROM Alunos;

--20-Calcule a média das idades dos alunos.
SELECT AVG(Alunos.Idade) AS MediaIdade FROM Alunos;

--21-Mostre o salário médio dos professores.
SELECT AVG(SalarioProfessor) AS MediaProfessor 
FROM Professores;

--22-Exiba o menor e o maior salário entre os professores
SELECT 
	MIN(SalarioProfessor) AS MenorSalario,
	MAX(SalarioProfessor) AS MaiorSalario
FROM Professores;

--23-Conte quantos cursos existem no total.
SELECT COUNT(Cursos.NomeCurso) AS QtdCursos FROM Cursos;

--24-Mostre quantas matrículas existem por curso (GROUP BY).
SELECT COUNT(IdMatricula) AS QtdMatriculas FROM Matriculas;

--25-Calcule a média das notas de cada curso (AVG + GROUP BY).
SELECT AVG(Nota) AS MediaNotas FROM Notas;