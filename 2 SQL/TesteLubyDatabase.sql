create database luby;

use luby;

create table tabela_pessoa(
	id int NOT NULL primary key, 
	nome varchar(50)
);

create table tabela_evento(
	id int not null primary key,
    evento varchar(10),
    pessoa_id int,
    constraint fkpessoa_id foreign key (pessoa_id) references tabela_pessoa(id)
);

insert into tabela_pessoa (id, nome) values (1, "John Doe");
insert into tabela_pessoa (id, nome) values (2, "Jane Doe");
insert into tabela_pessoa (id, nome) values (3, "Alice Jones");
insert into tabela_pessoa (id, nome) values (4, "Bobby Louis");
insert into tabela_pessoa (id, nome) values (5, "Lisa Romero");

insert into tabela_evento (id, evento, pessoa_id) values (1, "Evento A", 2);
insert into tabela_evento (id, evento, pessoa_id) values (2, "Evento B", 3);
insert into tabela_evento (id, evento, pessoa_id) values (3, "Evento C", 2);
insert into tabela_evento (id, evento, pessoa_id) values (4, "Evento D", null);

select * from tabela_pessoa;
select * from tabela_evento;

#2.1 Crie uma query para selecionar todas as pessoas 'tabela_pessoa' 
#e os respectivos eventos 'tabela_evento' o qual elas participam.
select * from tabela_pessoa
	left join tabela_evento
    on tabela_pessoa.id = tabela_evento.pessoa_id;

#2.2 Crie uma query para selecionar
#todas as pessoas 'tabela_pessoa' com sobrenome 'Doe'.
select * from tabela_pessoa where nome like '%Doe%';

#2.3 Crie uma query para adicionar um novo evento 'tabela_evento'
#e relacionar à pessoa 'Lisa Romero'.
insert into tabela_evento (id, evento, pessoa_id) values (5, "Evento E", 5);

#2.4 Crie uma query para atualizar 'Evento D' 
#na 'tabela_evento' e relacionar à pessoa 'Joh Doe'
update tabela_evento set pessoa_id =  1 where evento = "Evento D";

#2.5 Crie uma query para remover o 'Evento B' na 'tabela_evento'
Delete from tabela_evento where evento = "Evento B";

#2.6 Crie uma query para remover todas as pessoas 'tabela_pessoa'
#que não possuem eventos 'tabela_evento' relacionados
delete FROM tabela_pessoa e
where e.id not in (SELECT pessoa_id FROM tabela_evento);  

#2.7 Crie uma query para alterar a tabela 'tabela_pessoa'
#e adicionar a coluna 'idade' (int)
alter table tabela_pessoa add (idade int);

#2.8 Crie uma query para criar uma tabela chamada 'tabela_telefone' 
#que pertence a uma pessoa com seguintes campos:\
#	id: int (PK)
#   telefone: varchar(200)
#   pessoa_id: int(FK)
create table tabela_telefone(
	id int NOT NULL primary key, 
	telefone varchar(200),
    pessoa_id int,
    constraint fkpessoa_tel foreign key (pessoa_id) references tabela_pessoa(id)
);

#2.9 Crie uma query para criar uma índice do tipo único 
#na coluna telefone da 'tabela_telefone'.
alter table tabela_telefone ADD INDEX IndiceTel(telefone);

#2.10 Crie uma query para remover a 'tabela_telefone'.
drop table tabela_telefone;
show tables;

