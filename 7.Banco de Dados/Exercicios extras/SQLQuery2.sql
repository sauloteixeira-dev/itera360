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
SELECT
	nomeCurso,
	AVG(Nota) AS MediaNotas 
FROM Notas 
INNER JOIN Cursos 
ON Notas.IdCurso = Cursos.IdCurso
GROUP BY NomeCurso ;


--26-Exiba a quantidade de alunos por estado.
SELECT
    Estado,
    COUNT(*) AS QtdAlunos
FROM Alunos
GROUP BY Estado;

--27-Mostre o total de carga horária ministrada por cada professor.
SELECT 
	Professores.NomeProfessor,
	SUM(Cursos.CargaHoraria) AS TotalCargaHoraria
FROM   Professores 
INNER JOIN Cursos
	ON CURSOS.IdProfessor = Professores.IdProfessor
GROUP BY
	Professores.IdProfessor,
	NomeProfessor;

--28-Liste o curso com a maior média de notas.
SELECT TOP 3
	NomeCurso,
	AVG(Notas.nota) AS MediaNotas
FROM Cursos
INNER JOIN Notas 
	ON Cursos.IdCurso = Notas.IdCurso
GROUP BY 
	NomeCurso
ORDER BY
	MediaNotas DESC;

--29-Calcule a média geral de todas as notas dos alunos.
SELECT
    AVG(Nota) AS MediaGeral
FROM Notas;

--Media de cada aluno
SELECT 
	Alunos.NomeAluno,
	AVG(Notas.Nota) AS MediaNotas
FROM Notas
INNER JOIN Alunos 
	ON Notas.IdAluno = Alunos.IdAluno
GROUP BY NomeAluno

--30- Mostre o aluno com a maior nota registrada.
SELECT TOP 1
	Alunos.NomeAluno,
	MAX(nota) AS MaiorNota
FROM Alunos
INNER JOIN Notas 
	ON Alunos.IdAluno = Notas.IdAluno
GROUP BY NomeAluno
ORDER BY MaiorNota DESC;

--Comandos de Inserção, Atualização e Exclusão (INSERT, UPDATE, DELETE)--

--31-Insira um novo aluno chamado “Maria Silva”, de 17 anos, da cidade de Salvador (BA)
INSERT INTO Alunos (NomeAluno,Idade,Cidade,Estado) VALUES ('Marina Silva',17,'Salvador','BA')

--32-Insira um novo curso chamado “Banco de Dados” com carga horária de 80h,ministrado por “João Pereira”.
INSERT INTO Cursos (NomeCurso, CargaHoraria, IdProfessor) VALUES ('Banco de Dados',80,5)

--33-Atualize o salário de todos os professores com um aumento de 10%
UPDATE Professores
SET SalarioProfessor = SalarioProfessor * 1.10;

--34-Atualize a cidade dos alunos do estado “SP” para “São Paulo (Capital)”.
UPDATE Alunos 
SET Cidade = 'São Paulo (capital)'
WHERE Estado = 'SP';

--35-Atualize a nota do aluno “Lucas Almeida” no curso de “Matemática Básica” para 9.5.

UPDATE Notas
SET Nota = 9.5
FROM Notas
INNER JOIN Alunos
	ON Notas.IdAluno = Alunos.IdAluno
INNER JOIN Cursos
	ON Cursos.IdCurso = Notas.IdCurso
WHERE Alunos.NomeAluno = 'Lucas Almeida'
AND Cursos.NomeCurso = 'Matemática Básica';

--pesquisa pois foram encontradas duas linhas iguais...
SELECT *
FROM Notas
INNER JOIN Alunos
    ON Notas.IdAluno = Alunos.IdAluno
INNER JOIN Cursos
    ON Cursos.IdCurso = Notas.IdCurso
WHERE Alunos.NomeAluno = 'Lucas Almeida'
AND Cursos.NomeCurso = 'Matemática Básica';

--36-Exclua as notas menores que 6.0.
DELETE FROM Notas
WHERE Nota<6

--37-Exclua todos os alunos sem matrícula.
DELETE FROM Alunos
WHERE NOT EXISTS(
	SELECT 1
	FROM Matriculas
	WHERE Matriculas.IdAluno = Alunos.IdAluno);

--38-Insira uma nova nota para o aluno “Fernanda Costa” no curso “Gramática Avançada” (nota 8.0).
INSERT INTO Notas (IdAluno, IdCurso, Nota)
SELECT
    (SELECT IdAluno FROM Alunos WHERE NomeAluno = 'Fernanda Costa'),
    (SELECT IdCurso FROM Cursos WHERE NomeCurso = 'Gramática Avançada'),
    8.0;

--39-Atualize o curso “História do Brasil” para ter 60h de carga horária
UPDATE Cursos
SET CargaHoraria = 60
WHERE NomeCurso = 'História do Brasil'


--40-Exclua o curso “Lógica de Programação” (lembre-se de tratar as chaves estrangeiras)
-- ID DO CURSO
SELECT IdCurso
FROM Cursos
WHERE NomeCurso = 'Lógica de Programação';

-- VISUALIZAR SE TEM NOTAS VINCULADAS
SELECT *
FROM Notas
WHERE IdCurso = (
    SELECT IdCurso
    FROM Cursos
    WHERE NomeCurso = 'Lógica de Programação'
);

-- VISUALIZAR SE TEM MATRICULAS VINCULADAS
SELECT *
FROM Matriculas
WHERE IdCurso = (
    SELECT IdCurso
    FROM Cursos
    WHERE NomeCurso = 'Lógica de Programação'
);

-- EXCLUIR NOTAS VINCULADAS
DELETE FROM Notas
WHERE IdCurso = (
    SELECT IdCurso
    FROM Cursos
    WHERE NomeCurso = 'Lógica de Programação'
);

-- EXCLUIR MATRICULAS VINCULADAS
DELETE FROM Matriculas
WHERE IdCurso = (
    SELECT IdCurso
    FROM Cursos
    WHERE NomeCurso = 'Lógica de Programação'
);

-- DEPOIS EXCLUIR O CURSO
DELETE FROM Cursos
WHERE NomeCurso = 'Lógica de Programação';


-- Estrutura do Banco (CREATE, ALTER, DROP)

--41-Crie uma nova tabela chamada Turmas com os campos: IdTurma (PK) ● NomeTurma ● AnoLetivo
CREATE TABLE Turmas (
    IdTurma INT IDENTITY(1,1) PRIMARY KEY,
    NomeTurma VARCHAR(100) NOT NULL,
    AnoLetivo INT    
);

--42-Adicione um campo Email à tabela Professores.
ALTER TABLE Professores
ADD Email VARCHAR(100)

--43-Altere o tipo do campo Cidade na tabela Alunos para VARCHAR(100).
ALTER TABLE Alunos
ALTER COLUMN Cidade VARCHAR(100);

--44-Crie uma nova tabela Departamentos com: ● IdDepartamento (PK) ● NomeDepartamento ● IdProfessorChefe (FK para Professores)
CREATE TABLE Departamentos(
	IdDepartamento INT IDENTITY(1,1) PRIMARY KEY,
	NomeDepartamento VARCHAR(50),
	IdProfessorChefe INT,
FOREIGN KEY(IdProfessorChefe)
	REFERENCES Professores(IdProfessor));

--45-Exclua a tabela Departamentos.
DROP TABLE Departamentos

--46-Exclua a tabela Turmas.
DROP TABLE Turmas



--Desafios (Consultas Complexas)---

--47- Liste o nome do professor e a quantidade de cursos que ele ministra.
SELECT 
	Professores.NomeProfessor,
	COUNT(cursos.NomeCurso) AS QtdCursos
FROM Professores
INNER JOIN Cursos
	ON Professores.IdProfessor = Cursos.IdProfessor
GROUP BY NomeProfessor
ORDER BY NomeProfessor DESC;

--48-Mostre o nome do aluno e sua média geral (usando AVG sobre as notas).
SELECT 
	Alunos.NomeAluno,
	AVG(Nota) AS MediaNotas
FROM Alunos
INNER JOIN Notas
	ON Alunos.IdAluno = Notas.IdAluno
GROUP BY NomeAluno,Alunos.IdAluno
ORDER BY NomeAluno;

--49-Liste os alunos com notas acima da média geral.
SELECT DISTINCT
    Alunos.NomeAluno
FROM Alunos
INNER JOIN Notas
    ON Alunos.IdAluno = Notas.IdAluno
WHERE Notas.Nota > (
    SELECT AVG(Nota)
    FROM Notas
);

--50-Exiba o curso mais popular, ou seja, aquele com o maior número de matrículas.
SELECT TOP 1
	Cursos.NomeCurso,
	COUNT(*) AS Qtd
FROM Cursos
INNER JOIN Matriculas
	ON Matriculas.IdCurso = Cursos.IdCurso
	GROUP BY NomeCurso
	ORDER BY Qtd DESC;

--51-Mostre o professor com o maior salário e o curso que ele ministra.
SELECT
    Professores.NomeProfessor,
    Professores.SalarioProfessor,
    Cursos.NomeCurso
FROM Professores
INNER JOIN Cursos
    ON Professores.IdProfessor = Cursos.IdProfessor
ORDER BY Professores.SalarioProfessor DESC;


--52-Liste todos os alunos e suas notas, mesmo que o aluno ainda não tenha nota lançada (LEFT JOIN).
SELECT
    Alunos.NomeAluno,
    Notas.Nota
FROM Alunos
LEFT JOIN Notas
    ON Alunos.IdAluno = Notas.IdAluno;


--53-Exiba o total de alunos matriculados por professor (usando JOIN entre todas as tabelas).
SELECT
    Professores.NomeProfessor,
    COUNT(DISTINCT Alunos.IdAluno) AS TotalAlunos
FROM Professores
INNER JOIN Cursos
    ON Professores.IdProfessor = Cursos.IdProfessor
INNER JOIN Matriculas
    ON Cursos.IdCurso = Matriculas.IdCurso
INNER JOIN Alunos
    ON Matriculas.IdAluno = Alunos.IdAluno
GROUP BY Professores.IdProfessor, Professores.NomeProfessor;


--54-Mostre o nome do aluno, curso e diferença entre sua nota e a média do curso.
SELECT
    Alunos.NomeAluno,
    Cursos.NomeCurso,
    Notas.Nota,
    AVG(Notas.Nota) OVER (PARTITION BY Cursos.IdCurso) AS MediaCurso,
    Notas.Nota - AVG(Notas.Nota) OVER (PARTITION BY Cursos.IdCurso) AS DiferencaMedia
FROM Alunos
INNER JOIN Notas
    ON Alunos.IdAluno = Notas.IdAluno
INNER JOIN Cursos
    ON Notas.IdCurso = Cursos.IdCurso;


--55-Calcule a quantidade de alunos por faixa etária (menores de 18, de 18 a 20, acima de 20).
SELECT
    CASE
        WHEN Idade < 18 THEN 'Menores de 18'
        WHEN Idade BETWEEN 18 AND 20 THEN 'De 18 a 20'
        ELSE 'Acima de 20'
    END AS FaixaEtaria,
    COUNT(*) AS QuantidadeAlunos
FROM Alunos
GROUP BY
    CASE
        WHEN Idade < 18 THEN 'Menores de 18'
        WHEN Idade BETWEEN 18 AND 20 THEN 'De 18 a 20'
        ELSE 'Acima de 20'
    END;


--56-Liste os professores com salário acima da média e quantos cursos cada um ministra.
SELECT
    Professores.NomeProfessor,
    Professores.SalarioProfessor,
    COUNT(Cursos.IdCurso) AS QtdCursos
FROM Professores
LEFT JOIN Cursos
    ON Professores.IdProfessor = Cursos.IdProfessor
WHERE Professores.SalarioProfessor > (
    SELECT AVG(SalarioProfessor)
    FROM Professores
)
GROUP BY
    Professores.IdProfessor,
    Professores.NomeProfessor,
    Professores.SalarioProfessor;


--57-Monte um relatório consolidado com as colunas: Nome do Aluno--Curso--Professor--Nota--Média do Curso--Situação ("Aprovado" se Nota >= 7, senão "Reprovado")
SELECT
    Alunos.NomeAluno,
    Cursos.NomeCurso,
    Professores.NomeProfessor,
    Notas.Nota,
    AVG(Notas.Nota) OVER (PARTITION BY Cursos.IdCurso) AS MediaCurso,
    CASE
        WHEN Notas.Nota >= 7 THEN 'Aprovado'
        ELSE 'Reprovado'
    END AS Situacao
FROM Alunos
INNER JOIN Notas
    ON Alunos.IdAluno = Notas.IdAluno
INNER JOIN Cursos
    ON Notas.IdCurso = Cursos.IdCurso
INNER JOIN Professores
    ON Cursos.IdProfessor = Professores.IdProfessor;
