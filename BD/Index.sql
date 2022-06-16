-- Usado MySQL
USE desafio;

ALTER TABLE PagamentoBoletos ADD INDEX IData (
    data_pagamento
);