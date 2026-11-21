create database SchoolDb
go
Use SchoolDb
go
Create Table Students(
Id int primary key identity(1,1),
FirstName varchar(50),
LastName varchar(50),
Age int
)

select * from Students