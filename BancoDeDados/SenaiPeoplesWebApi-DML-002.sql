
USE T_Peoples

INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES ('Catarina','Strada'), ('Tadeu','Vitelli');

INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES ('Administrador','Oliveira');

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'), ('Funcionario'), ('UsuarioComum');

INSERT INTO Usuario (IdTipoUsuario, IdFuncionario, Email, Senha)
VALUES (2, 1, 'catarina@gmail.com', 'cat123'), (2, 2, 'tadeu@gmail.com', 'tad123'), (1, 3,'adm@gmail.com', 'adm123' );

SELECT * FROM Funcionarios

SELECT * FROM TipoUsuario

SELECT * FROM Usuario