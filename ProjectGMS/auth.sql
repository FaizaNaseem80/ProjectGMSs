
create procedure auth
@Email varchar(50),
@Password varchar(50),
@Type varchar(50)
as
if(@Type='Admin')
select * from Employees where email=@Email and password=@Password
else if(@Type='Worker')
select * from Employees where email=@email and password=@Password
else
select * from Employees where email=@Email and password=@Password

GO

exec auth @Email='moiz80@gmail.com',@Password='moiz',@type='Admin'
exec auth @Email='mahii@gmail.com',@Password='mahii',@type='Worker'




