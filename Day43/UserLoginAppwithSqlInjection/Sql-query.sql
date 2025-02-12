create table userlogin(
id int primary key identity (100,1),
username varchar(50) not null,
userpwd varchar(20) not null,
msg varchar(50) 
 )

 alter table userlogin
 add msg varchar(50) 


 select * from userlogin


 delete userlogin where id=100;

 insert into userlogin(username,userpwd,msg) values ('Venkatesh',12345,'Welcome venkat');
 insert into userlogin(username,userpwd,msg) values ('Bala',54321,'welcome bala');
 insert into userlogin(username,userpwd,msg) values ('Sachin',11111,'welcome sachin');
