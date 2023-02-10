create database consultorio 
use consultorio

create table Médico(
Idmedico int primary key not null, 
nomemedico varchar(50), 
Crm varchar (10)
)

create table paciente1 (

idpaciente varchar (100),
nomepaciente varchar (120),
telefone varchar (120),
)

create table consulta(
IDconsulta int identity primary key not null, 
idpunheta int not null,
Idmedico int not null,
idpaciente int not null, 
dataconsulta datetime,
Horaincio datetime,
horafim datetime,
observacoes varchar(max),
ativo bit
)

