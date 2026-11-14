-- ordenando pelo nome
SELECT * FROM Clientes ORDER BY Nome ASC;

-- ordenando os pedidos maiores que
SELECT * FROM Pedidos WHERE ValorTotal > 10000 ORDER BY ValorTotal DESC;

--ordenando os produtos onde começam com C
SELECT * FROM Produtos WHERE Nome LIKE 'C%';

--Produtos com menor valor
SELECT * FROM Produtos WHERE Preco < 1000 ORDER BY Preco ASC;

--clientes com mais pedidos ??


--Pedidos com data de criação mais recente
SELECT * FROM Pedidos ORDER BY Data DESC;

-- 2 USANDO JOINS
--SELECT * FROM tabela1 INNER JOIN tabela2
--ON tabela1.coluna = tabela2.coluna;

--Quais são os clientes que compraram o produto mais caro?
SELECT * FROM Clientes
INNER JOIN Pedidos ON Clientes.ClienteID = Pedidos.ClienteID
INNER JOIN Produtos ON Pedidos.ProdutoID = Produtos.ProdutoID 
WHERE Produtos.Preco = (SELECT MAX(Preco) FROM Produtos);

--Quais são os produtos mais vendidos por cada cliente?
SELECT 
    Clientes.Nome AS Cliente, 
    Produtos.Nome AS Produto, 
    COUNT(Pedidos.PedidosID) AS Total_Compras
FROM Clientes
INNER JOIN Pedidos ON Clientes.ClienteID = Pedidos.ClienteID
INNER JOIN Produtos ON Pedidos.ProdutoID = Produtos.ProdutoID
GROUP BY Clientes.Nome, Produtos.Nome
ORDER BY Clientes.Nome, Total_Compras DESC;

--Quais são as categorias com mais pedidos?
SELECT 
    Categorias.Nome AS Categoria, 
    COUNT(Pedidos.PedidosID) AS Total_Pedidos
FROM Pedidos
INNER JOIN Produtos ON Pedidos.ProdutoID = Produtos.ProdutoID
INNER JOIN Categorias ON Produtos.CategoriaID = Categorias.CategoriasID
GROUP BY Categorias.Nome
ORDER BY Total_Pedidos DESC;


--3 Usando GROUP BY

--Quantas categorias existem?
SELECT COUNT(*) AS Total_Categorias
FROM Categorias;

--Quais são as categorias com mais produtos?
SELECT 
    Categorias.Nome AS Categoria, 
    COUNT(Produtos.ProdutoID) AS Total_Produtos
FROM Categorias
INNER JOIN Produtos ON Categorias.CategoriasID = Produtos.CategoriaID
GROUP BY Categorias.Nome
ORDER BY Total_Produtos DESC;

--Quais são as categorias com menor valor médio de produtos?
SELECT 
    Categorias.Nome AS Categoria, 
    AVG(Produtos.Preco) AS Media_Preco
FROM Categorias
INNER JOIN Produtos ON Categorias.CategoriasID = Produtos.CategoriaID
GROUP BY Categorias.Nome
ORDER BY Media_Preco ASC;




