
use rrd_db1
go
--Dimension Table/Parent Table

create table account(
account_number int primary key identity (100,1),
acc_name varchar(50) not null,
account_type varchar(50) not null,
acc_address varchar(200),
balance money )
--Alter the table by adding a column
alter table account
alter column balance money not null 


select * from account

--Child Table/FAct table
create table [transaction](
id int primary key identity (1,1),
transaction_type varchar(50) not null,
account_id int references account(account_number))

select * from [transaction]

--inserting the datas in to the account table

insert into account(acc_name,account_type,acc_address,balance) values ('Venkatesh','Saving','abc',5000)
insert into account(acc_name,account_type,acc_address,balance) values ('Sachin','Saving','cdb',50000)
insert into account(acc_name,account_type,acc_address,balance) values ('Prem','Saving','aaa',20000)
insert into account(acc_name,account_type,acc_address,balance) values ('Akhilesh','Saving','daj',10000)


--inserting the datas in to the transaction table

insert into [transaction](transaction_type,account_id) values ('withdraw',101)
insert into [transaction](transaction_type,account_id) values ('Deposit',101)
insert into [transaction](transaction_type,account_id) values ('withdraw',101)

insert into [transaction](transaction_type,account_id) values ('withdraw',102)
insert into [transaction](transaction_type,account_id) values ('Deposit',102)
insert into [transaction](transaction_type,account_id) values ('withdraw',102)