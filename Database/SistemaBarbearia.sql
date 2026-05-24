DROP DATABASE IF EXISTS SistemaBarbearia;

CREATE DATABASE SistemaBarbearia;
USE SistemaBarbearia;

CREATE TABLE Usuarios (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Login VARCHAR(50) NOT NULL UNIQUE,
    Senha VARCHAR(255) NOT NULL,
    Perfil VARCHAR(20) DEFAULT 'Recepcao'
);

CREATE TABLE Clientes (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    DataNascimento DATETIME,
    DataCadastro DATETIME
);

CREATE TABLE Servicos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(50) NOT NULL,
    Preco DECIMAL(10, 2) NOT NULL,
    DuracaoMinutos INT NOT NULL
);

CREATE TABLE Barbeiros (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    Nome VARCHAR(100) NOT NULL,
    Telefone VARCHAR(20) NOT NULL,
    Email VARCHAR(100) NOT NULL,
    DataNascimento DATETIME,
    PercentualComissao DECIMAL(10, 2) NOT NULL
);

CREATE TABLE Agendamentos (
    Id INT AUTO_INCREMENT PRIMARY KEY,
    ClienteId INT NOT NULL,
    ServicoId INT NOT NULL,
    BarbeiroId INT NOT NULL, 
    DataHora DATETIME NOT NULL,
    Status VARCHAR(20) DEFAULT 'Pendente',
    FOREIGN KEY (ClienteId) REFERENCES Clientes(Id),
    FOREIGN KEY (ServicoId) REFERENCES Servicos(Id),
    FOREIGN KEY (BarbeiroId) REFERENCES Barbeiros(Id)
);

INSERT INTO Usuarios (Nome, Login, Senha, Perfil) VALUES ('Administrador do Sistema', 'admin', 'admin123', 'Admin');