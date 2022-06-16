-- Usado MySQL
CREATE data_pagamentoBASE desafio;
USE desafio;

CREATE TABLE Contas (
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    numero_agencia      INT NOT NULL,
    numero_conta        INT NOT NULL
);

CREATE TABLE Depositos (
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    id_conta            INT NOT NULL,
    valor               INT NOT NULL,
    data_deposito       DATE NOT NULL,
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE Saques (
    id              INT PRIMARY KEY AUTO_INCREMENT,
    id_conta        INT NOT NULL,
    valor           INT NOT NULL,
    data_saque      DATE NOT NULL,
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE PagamentoBoletos (
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    id_conta            INT NOT NULL,
    valor               INT NOT NULL,
    data_pagamento      DATE NOT NULL,
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE EnvioTransferenciaExterna(
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    id_conta            INT NOT NULL,
    agencia_destino     INT NOT NULL,
    conta_destino       INT NOT NULL,
    documento           INT NOT NULL,
    valor               INT NOT NULL,
    data_envio          DATE NOT NULL,
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);

CREATE TABLE RecebimentoTransferenciaExterna(
    id                  INT PRIMARY KEY AUTO_INCREMENT,
    id_conta            INT NOT NULL,
    agencia_destino     INT NOT NULL,
    conta_destino       INT NOT NULL,
    documento           INT NOT NULL,
    valor               INT NOT NULL,
    data_recebimento    DATE NOT NULL,
    FOREIGN KEY (id_conta) REFERENCES Contas(id)
);
