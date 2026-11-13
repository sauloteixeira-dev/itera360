--Aula 12
--INNER JOIN
--TRÁS OS REGISTROS QUANDO EXISTEM NAS DUAS TABELAS
SELECT 
	Clientes.Nome, 
	Enderecos.Logradouro, 
	Enderecos.Cidade 
FROM
	Clientes 
INNER JOIN 
	Enderecos 
ON 
Clientes.ClienteID = Enderecos.ClienteID
WHERE
	Enderecos.Cidade = 'Alfenas';

--LEFT JOIN 
--SEMPRE A TABELA QUE TEM A --CHAVE PRIMÁRIA-- É A TABELA DA --ESQUERDA--
-- EXEMPLO: CLIENTES E ENDEREÇOS 
--A TABELA DA ESQUERDA SEMPRE VAI SER A TABELA CLIENTES!!
SELECT 
	Clientes.Nome, 
	Enderecos.Logradouro, 
	Enderecos.Cidade 
FROM
	Clientes 
LEFT JOIN
	Enderecos 
ON 
Clientes.ClienteID = Enderecos.ClienteID
--TRÁS TODOS OS DADOS DA TABELA PAI(clientes) MESMO QUE NÃO TENHAM RELAÇÃO COM A TABELA FILHA (enderecos)



--RIGHT JOIN 
--FAZ O OPOSTO DO LEFT
SELECT 
	Clientes.Nome, 
	Enderecos.Logradouro, 
	Enderecos.Cidade 
FROM
	Clientes 
RIGHT JOIN
	Enderecos 
ON 
Clientes.ClienteID = Enderecos.ClienteID
--TRÁS TODOS OS DADOS DA TABELA FILHA(ENDERECOS) MESMO QUE NÃO TENHAM RELAÇÃO COM A TABELA PAI(CLIENTES)


--FULL OUTER JOIN
SELECT 
	Clientes.Nome, 
	Enderecos.Logradouro, 
	Enderecos.Cidade 
FROM
	Clientes 
FULL OUTER JOIN
	Enderecos 
ON 
Clientes.ClienteID = Enderecos.ClienteID
--O INVERSO DE INNER JOIN ... APRESENTA TODOS OS DADOS ...OS QUE TEM RELAÇÃO E OS QUE NÃO TEM RELAÇÃO