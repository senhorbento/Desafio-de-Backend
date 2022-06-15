-- Usado MySQL
CREATE DATABASE desafio;
USE desafio;

CREATE TABLE Contas (
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    numero_agencia      INT NOT NULL,
    numero_conta        INT NOT NULL
);

CREATE TABLE Depositos (
    id_conta    INT PRIMARY KEY AUTO_INCREMENT
    valor       INT NOT NULL
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE Saques (
    id_conta    INT PRIMARY KEY AUTO_INCREMENT
    valor       INT NOT NULL
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE PagamentoBoletos (
    id_conta    INT PRIMARY KEY AUTO_INCREMENT
    valor       INT NOT NULL
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

--transferências para outros bancos (agência, conta e documento)
--recebimento de transferências de outros bancos