create database registro
use registro
create table users(
id varchar (10) not null,
idnom varchar (30) not null,
email varchar (50) not null,
pass varchar (20) not null,
constraint pk_users primary key(id)
)
create procedure alta_users(
@id varchar (20),
@nom varchar (30),
@email varchar (50),
@pass varchar (20)
)
as
insert into users
values (@id,@nom,@email,@pass)
go
create procedure ver_users(
@id varchar(20)
)
as
select *from users
where id=@id
go