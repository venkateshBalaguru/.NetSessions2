-- This a Comment
/*
Creating a product Table

*/
/* DDL */
create table Product(
id int primary key identity(1,1),
name varchar(100),
quantity int,
price money
)
--DQL
select * from product
--DML
insert into Product(name,quantity,price)
values('Laptop',5,50000);
insert into Product(name,quantity,price)
values('Mobile',4,20000);
insert into Product(name,quantity,price)
values('PC',10,40000);
--Update

update product
set quantity = 20 --We can update like this other wise we can use variable
where id =2;
declare @newQuantity int --this is using variable updating
set @newQuantity =5;
update product
set quantity = @newQuantity
where id =3;

select * from Product where name = 'PC';

delete product where id =3;

