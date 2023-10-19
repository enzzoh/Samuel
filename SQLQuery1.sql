use master 
go
create database siteTCC
use siteTCC
create table produtos (
proID int identity(1,1) primary key,
nomeproduto varchar(100),
preco float,
descricaoproduto varchar(100)

)




INSERT INTO produtos (nomeproduto, preco, descricaoproduto)
VALUES ('Product 1', 19.99, 'Description of Product 1'),
       ('Product 2', 29.99, 'Description of Product 2'),
       ('Product 3', 39.99, 'Description of Product 3');
	   select * from produtos