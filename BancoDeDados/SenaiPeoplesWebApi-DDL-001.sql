CREATE DATABASE T_Peoples

USE T_Peoples

CREATE TABLE Funcionarios (
IdFuncionarios		INT PRIMARY KEY IDENTITY,
Nome				VARCHAR(150) NOT NULL,
Sobrenome			VARCHAR(150) NOT NULL
);

CREATE TABLE TipoUsuario (
IdTipoUsuario		INT PRIMARY KEY IDENTITY,
Titulo				VARCHAR(50) NOT NULL
);

CREATE TABLE Usuario (
IdUsuario			INT PRIMARY KEY IDENTITY,
IdTipoUsuario		INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario),
IdFuncionario		INT FOREIGN KEY REFERENCES Funcionarios (Idfuncionarios),
Email				VARCHAR(150) NOT NULL UNIQUE,
Senha				VARCHAR(50) NOT NULL
);

