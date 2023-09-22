create database MBANF_BD
use MBANF_BD
go

create table Users (
	_id int identity (1000, 1),
	_name varchar (50),
	_lastname varchar (50),
	_birthdate date,
	_user varchar (50),
	_password varbinary (500)
)

go 

create procedure SP_validateUser
@User varchar(50),
@Password varchar(50),
@Pattern varchar(50)
as
begin
select*from Users where _users=@User and CONVERT(varchar(50), DECRYPTBYPASSPHRASE(@Pattern, _password))=@Password
end

go
select * from Users