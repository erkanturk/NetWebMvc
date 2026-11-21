Create database ETradeDb
go
use EtradeDb
Go
create table Categories(
CategoryId int primary key identity(1,1),
[Name] varchar(50) not null
)
go
create table Products(
ProductId int primary key identity(1,1),
[Name] varchar(50) not null,
Price decimal(18,2) not null,
CategoryId int foreign key (CategoryId) references Categories(CategoryId)
)