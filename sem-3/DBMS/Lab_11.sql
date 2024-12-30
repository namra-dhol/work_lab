CREATE TABLE STU_INFO(
RNO INT,
NAME VARCHAR(10),
BRANCH VARCHAR(10))

INSERT INTO STU_INFO (RNO,NAME,BRANCH)
VALUES
(101,'Raju','CE'),  
(102,'Amit','CE'),  
(103,'Sanjay','ME'), 
(104,'Neha','EC'),  
(105,'Meera','EE'),  
(106,'Mahesh','ME') 

CREATE TABLE RESULT(
RNO INT,
SPI DECIMAL(2,1))
INSERT INTO RESULT(RNO,SPI)
VALUES
(101,8.8),
(102,9.2),
(103,7.6),
(104,8.2),
(105,7.0),
(107,8.9)


CREATE TABLE EMPLOYE_MASTER
(
	EMPLOYEENO VARCHAR(10),
	NAME VARCHAR(10),
	MANAGERNO VARCHAR(10)
)
INSERT INTO EMPLOYE_MASTER(EMPLOYEENO,NAME,MANAGERNO)
VALUES
('E01','Tarun',NULL),
('E02','Rohan','E02'),
('E03','Priya','E01'),
('E04','Milan','E03'),
('E05','Jay','E01') ,
('E06','Anjana','E04')

--Part � A:
--1. Combine information from student and result table using cross join or Cartesian product.
SELECT * FROM STU_INFO CROSS JOIN RESULT

--2. Perform inner join on Student and Result tables.
SELECT * FROM STU_INFO INNER JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno

--3. Perform the left outer join on Student and Result tables.
SELECT * FROM STU_INFO LEFT OUTER JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno


--4. Perform the right outer join on Student and Result tables.
SELECT * FROM STU_INFO RIGHT OUTER JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno


--5. Perform the full outer join on Student and Result tables. 
SELECT * FROM STU_INFO FULL OUTER JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno

--6. Display Rno, Name, Branch and SPI of all students.
SELECT STU_INFO.Rno, STU_INFO.Name, STU_INFO.Branch, RESULT.SPI FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno

--7. Display Rno, Name, Branch and SPI of CE branch�s student only.
SELECT STU_INFO.Rno, STU_INFO.Name, STU_INFO.Branch, RESULT.SPI FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
WHERE STU_INFO.Branch = 'CE'

--8. Display Rno, Name, Branch and SPI of other than EC branch�s student only.
SELECT STU_INFO.Rno, STU_INFO.Name, STU_INFO.Branch, RESULT.SPI FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
WHERE STU_INFO.Branch <> 'EC'


--9. Display average result of each branch.
SELECT STU_INFO.Branch,AVG(RESULT.SPI) FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
GROUP BY STU_INFO.Branch

--10. Display average result of CE and ME branch
SELECT STU_INFO.Branch,AVG(RESULT.SPI) FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
WHERE STU_INFO.Branch IN ('CE','ME')
GROUP BY STU_INFO.Branch


--Part � B:
--1. Display average result of each branch and sort them in ascending order by SPI.
SELECT STU_INFO.Branch,AVG(RESULT.SPI) FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
GROUP BY STU_INFO.Branch
ORDER BY AVG(RESULT.SPI)

--2. Display highest SPI from each branch and sort them in descending order.
SELECT STU_INFO.Branch,MAX(RESULT.SPI) FROM STU_INFO JOIN RESULT
ON STU_INFO.Rno = RESULT.Rno
GROUP BY STU_INFO.Branch
ORDER BY MAX(RESULT.SPI) DESC