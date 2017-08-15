create database CheckOut
go

use CheckOut
go

create table Shopping
(
	ID int primary key identity,
	ItemName nvarchar(50),
	Quantity int
)

insert into Shopping values ('Coke', 10)
insert into Shopping values ('Pen', 50)
insert into Shopping values ('Pencils', 100)
insert into Shopping values ('Copybooks', 200)
