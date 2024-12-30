
CREATE TABLE CRICKET(
NAME VARCHAR(50),
CITY VARCHAR(50),
AGE INT
)
INSERT INTO CRICKET (NAME,CITY,AGE)
VALUES
('Sachin Tendulkar','Mumbai',30),
('Rahul Dravid','Bombay',35),
('M. S. Dhoni','Jharkhand',31),
('Suresh Raina','Gujarat',30)

--Create table Worldcup from cricket with all the columns and data
SELECT*INTO WORLDCUP FROM CRICKET

--Create table T20 from cricket with first two columns with no data
SELECT NAME,CITY INTO T20 FROM CRICKET

--Create table IPL From Cricket with No Data
SELECT *INTO IPL FROM CRICKET
WHERE 1=2

CREATE TABLE EMPLOYEE(
NAME VARCHAR(50),
CITY VARCHAR(50),
AGE INT
)

INSERT INTO EMPLOYEE (NAME,CITY,AGE)
VALUES
('Jay Patel','Rajkot',30),
('Rahul Dave','Baroda',35),
('Jeet Patel','Surat',31),
('Vijay Raval','Rajkot',30)

--Create table EMPLOYEE_DETAIL from EMPLOYEE with all the columns and data
SELECT*INTO EMPLOYEE_DETAIL FROM EMPLOYEE

--Create table EMPLOYEE_DATA from EMPLOYEE with first two columns with no data
SELECT NAME,CITY INTO EMPLOYEE_DATA FROM EMPLOYEE

--Create table EMPLOYEE_INFO From EMPLOYEE with No Data
SELECT *INTO EMPLOYEE_INFO FROM EMPLOYEE
WHERE 1=2

--PART-C
--Insert the Data into Employee_info from Employee whose CITY is Rajkot
INSERT INTO EMPLOYEE_INFO(NAME,CITY,AGE)
SELECT NAME,CITY,AGE FROM EMPLOYEE
WHERE CITY ='RAJKOT'

--Insert the Data into Employee_info from Employee whose age is more than 32.
INSERT INTO EMPLOYEE_INFO(NAME,CITY,AGE)
SELECT NAME,CITY,AGE FROM EMPLOYEE
WHERE AGE>32

--Update Operation
--Part – A: 
--Update deposit amount of all customers from 3000 to 5000
UPDATE DEPOSIT
SET AMOUNT=5000
WHERE AMOUNT=3000

--Change branch name of ANIL from VRCE to C.G. ROAD
UPDATE BORROW
SET BNAME='C.G.ROAD'
WHERE CNAME='ANIL' AND BNAME='VRCE'

--Update Account No of SANDIP to 111 & Amount to 5000
UPDATE DEPOSIT
SET ACTNO=111,AMOUNT=5000
WHERE CNAME='SANDIP'

--Update amount of KRANTI to 7000
UPDATE DEPOSIT
SET AMOUNT=7000
WHERE CNAME='KRANTI'

--Update branch name from ANDHERI to ANDHERI WEST
UPDATE BRANCH
SET BNAME ='ANDHERI WEST'
WHERE BNAME='ANDHERI'

--Update branch name of MEHUL to NEHRU PALACE
UPDATE DEPOSIT 
SET BNAME='NEHRU PLACE'
WHERE CNAME='MEHUL'

--Update deposit amount of all depositors to 5000 whose account no between 103 & 107.
UPDATE DEPOSIT
SET AMOUNT=5000
WHERE ACTNO BETWEEN 103 AND 107

--Update ADATE of ANIL to 1-4-95
UPDATE DEPOSIT
SET ADATE='1-4-95'
WHERE CNAME='ANIL'

--Update the amount of MINU to 10000
UPDATE DEPOSIT
SET AMOUNT=10000
WHERE CNAME='MINU'

--Update deposit amount of PRAMOD to 5000 and ADATE to 1-4-96 
UPDATE DEPOSIT
SET AMOUNT=5000,ADATE='1-4-96'
WHERE CNAME='PRAMOD'
