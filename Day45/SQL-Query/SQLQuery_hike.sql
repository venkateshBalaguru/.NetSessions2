CREATE PROCEDURE usp_givehike 
    @DeptNo INT,
    @HikePercentage FLOAT
	AS
BEGIN
    
    UPDATE EMP1
    SET EMP1.SAL = EMP1.SAL + (EMP1.SAL * @HikePercentage / 100)
    WHERE EMP1.DEPT1NO = @Dept1No;

    UPDATE EMP1
    SET EMP1.COMM = EMP1.COMM + (EMP1.COMM * @HikePercentage / 100)
    WHERE EMP1.DEPT1NO = @Dept1No AND EMP1.COMM IS NOT NULL;
END;

ALTER PROCEDURE usp_givehike 
    @DeptNo INT,
    @HikePercentage FLOAT
AS
BEGIN
    UPDATE EMP
    SET EMP.SAL = EMP.SAL + (EMP.SAL * @HikePercentage / 100)
    WHERE EMP.DEPTNO = @DeptNo;
	   
    UPDATE EMP
    SET EMP.COMM = EMP.COMM + (EMP.COMM * @HikePercentage / 100)
    WHERE EMP.DEPTNO = @DeptNo AND EMP.COMM IS NOT NULL;
	   
    SELECT 
    EMPNO, ENAME, DEPTNO, SAL, COMM
    FROM EMP
    WHERE DEPTNO = @DeptNo;
END;

ALTER PROCEDURE usp_givehike 
    @DeptNo INT,
    @HikePercentage FLOAT
AS
BEGIN
   
   UPDATE EMP
    SET EMP.SAL = EMP.SAL + (EMP.SAL * (@HikePercentage / 2) / 100)
    WHERE EMP.DEPTNO = @DeptNo AND EMP.COMM IS NULL;

    UPDATE EMP
    SET EMP.SAL = EMP.SAL + (EMP.SAL * @HikePercentage / 100)
    WHERE EMP.DEPTNO = @DeptNo AND EMP.COMM IS NOT NULL;

    UPDATE EMP
    SET EMP.COMM = EMP.COMM + (EMP.COMM * @HikePercentage / 100)
    WHERE EMP.DEPTNO = @DeptNo AND EMP.COMM IS NOT NULL;

    SELECT 
    EMPNO, ENAME, DEPTNO, SAL, COMM
    FROM EMP
    WHERE DEPTNO = @DeptNo;
END;



EXEC usp_givehike @DeptNo = 10, @HikePercentage = 30;

EXEC sp_helptext 'usp_givehike';