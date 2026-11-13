--AULA 11
--apagar a tabela completa
--DROP TABLE Enderecos;

ALTER TABLE Enderecos
	ADD FOREIGN KEY (ClienteID) REFERENCES Clientes(ClienteID);

INSERT INTO Enderecos (Logradouro, Cidade, UF, ClienteID) VALUES ('Rua da Saudade','Alfenas','MG',1);
INSERT INTO Enderecos (Logradouro, Cidade ,UF, ClienteID) VALUES ('Rua Concordia','Alfenas','MG',2);
INSERT INTO Enderecos (Logradouro, Cidade ,UF, ClienteID) VALUES ('Av. Governador Valadares','Alfenas','MG',3);
--INSERT INTO Enderecos (Logradouro, Cidade ,UF, ClienteID) VALUES ('Av. Pres. Arthur Bernardes','Alfenas','MG',6);
--não tem ClienteID = 6;



SELECT * FROM Enderecos