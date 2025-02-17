select * from userlogin;
alter table userlogin
alter column userpwd varchar(20) null

SELECT * FROM USERLOGIN WHERE ID = 1 or 1=1 AND USERPWD = '1' or 1=1

	SELECT GETDATE() AS 'TODAY' FROM  USERLOGIN

	SELECT CONVERT(VARCHAR,GETDATE(),100) AS 'FORMATTEDDATE';
	SELECT FORMAT(GETDATE(), 'MM/dd/yyyy hh:mm:ss tt') AS CustomDateTime;

	SELECT FORMAT(GETDATE(), 'yyyyMMddhhmmss') AS CustomDateTime;


