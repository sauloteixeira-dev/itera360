--COMANDOS
SELECT COUNT(ClienteID) AS TotalDePedidos FROM Pedidos WHERE ClienteID = 2;--CONTAR

SELECT SUM(ValorTotal) AS TotalDePedidos FROM Pedidos WHERE ClienteID = 2;--SOMAR

SELECT AVG(ValorTotal) AS TotalDePedidos FROM Pedidos WHERE ClienteID = 2;--MEDIA

SELECT MIN(ValorTotal) AS TotalDePedidos FROM Pedidos WHERE ClienteID = 2;--MINIMO
SELECT MAX(ValorTotal) AS TotalDePedidos FROM Pedidos WHERE ClienteID = 2;--MAXIMO

INSERT INTO Pedidos (ClienteID,ProdutoID,Data,ValorTotal) VALUES (1,1,'2026-11-04 15:30:43',150.00)
INSERT INTO Pedidos (ClienteID,ProdutoID,Data,ValorTotal) VALUES (1,2,'2026-11-04 15:32:43',200.00)
INSERT INTO Pedidos (ClienteID,ProdutoID,Data,ValorTotal) VALUES (1,3,'2026-11-04 16:32:43',200.00)

SELECT 
	ClienteID,
	SUM(ValorTotal) AS TotaldePedidos,
	COUNT(PedidosID) AS QuantidadeDePedidos
FROM
	Pedidos
GROUP BY
	ClienteID;


SELECT 
	TOP 2 -- DUAS PRIMEIRAS LINHAS
	ClienteID,
	SUM(ValorTotal) AS TotaldePedidos,
	COUNT(PedidosID) AS QuantidadeDePedidos
FROM
	Pedidos
GROUP BY --agrupar
	ClienteID
ORDER BY -- ordernar
	TotaldePedidos ASC; -- = menor para o maior --DESC do maior para o menor

--DISTINCT
SELECT DISTINCT ClienteID FROM Pedidos; --somente os que tem registro na tabela de pedidos
	