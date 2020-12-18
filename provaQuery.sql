CREATE TABLE Pessoa (
    ID int,
    DepID int,
    Nome varchar(255),
    Salario Decimal	

	primary key(ID)
);

ALTER TABLE Pessoa
ADD FOREIGN KEY (DepID) REFERENCES Departamento(ID);

CREATE TABLE Departamento (
	ID int,
	Nome varchar(255)

	primary key(ID)
);

insert into Pessoa values(1,1,'joe',70000)
insert into Pessoa values(2,2,'Henry',80000)
insert into Pessoa values(3,2,'Sam',60000)
insert into Pessoa values(4,1,'Max',90000)

insert into Departamento values(1,'TI')
insert into Departamento values(2,'Vendas')

select 
CASE  p.DepID
     WHEN 1 THEN 'TI'
	 WHEN 2 THEN 'Vendas'
END NomeDepartamento,
p.nome,
p.Salario
from
(
	select MAx(p.Salario) salario from Pessoa p
	join Departamento d on p.DepID = d.ID
	group by d.Nome
) D
join Pessoa p
on p.Salario = d.salario