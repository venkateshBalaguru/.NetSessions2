create database rrd_MySqlDB;
use rrd_MySqlDB; 
CREATE TABLE employee (
EmpId int auto_increment primary key,
Name varchar(200),
Address varchar(255),
City varchar(255)
);

select * from employee;

insert into employee(Name, Address, City) Values	('Venkatesh','abc','Madurai');
insert into employee(Name, Address, City) Values	('Bala','bdc','Chennai');