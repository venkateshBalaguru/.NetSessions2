create database rrd_MySqlDB;
use rrd_MySqlDB; 
CREATE TABLE employee (
EmpId int auto_increment primary key,
Name varchar(200),
Address varchar(255),
City varchar(255)
);

select * from todolist;
delete from TodoList where Id = 2;
Update  TodoList set Priority = Normal where ID = 4;
SELECT * FROM USERLOGIN WHERE ID = " + userId + " AND USERPWD = '" + userPwd + "'";

delete from todolist where id = 1;

insert into employee(Name, Address, City) Values	('Venkatesh','abc','Madurai');
insert into employee(Name, Address, City) Values	('Bala','bdc','Chennai');