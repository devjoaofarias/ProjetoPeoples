USE T_Peoples

INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES ('Catarina','Strada'), ('Tadeu','Vitelli');

INSERT INTO Funcionarios (Nome, Sobrenome) 
VALUES ('Administrador','Oliveira');

INSERT INTO TipoUsuario (Titulo)
VALUES ('Administrador'), ('Funcionario'), ('UsuarioComum');

INSERT INTO Usuario (IdTipoUsuario, IdFuncionario, Email, Senha)
VALUES (1, 5, 'admin@gmail.com', '123123'), (2, 1, 'catarina@gmail.com', 'cat123'), (2, 2, 'tadeu@gmail.com', 'tad123'), (2, 4, 'joao@gmail.com', 'joaojoao');

SELECT * FROM Funcionarios

SELECT * FROM TipoUsuario

SELECT * FROM Usuario