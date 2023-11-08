USE master

create database siteTCC
use siteTCC

CREATE TABLE produtos
(
    proID  int identity(1,1) PRIMARY KEY ,
    nomeproduto VARCHAR(255),
    preco FLOAT,
    descricaoproduto VARCHAR(1000),
    fotoproduto VARCHAR(MAX)
);
