SELECT myTimeStamb(GETDATE()) AS 'FORMATED TIME' FROM userlogin;

create table checkdate(
id int primary key identity(1,1),
datetoday datetime);

select * from checkdate

insert into checkdate(datetoday) values (GETDATE())

select DBO.myTimeStamb(GETDATE())  