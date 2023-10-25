use master
create database siteTCC

use siteTCC

create table produtos (
   proID int identity(1,1) primary key,
   nomeproduto varchar(100),
   preco float,
   descricaoproduto varchar(100),
   fotoproduto varchar(max)
  )
  select * from produtos
