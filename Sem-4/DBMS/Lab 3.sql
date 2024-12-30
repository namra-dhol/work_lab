Create database DBMS_2

CREATE TABLE Departments ( 
DepartmentID INT PRIMARY KEY, 
DepartmentName VARCHAR(100) NOT NULL UNIQUE, 
ManagerID INT NOT NULL, 
Location VARCHAR(100) NOT NULL 
); 

CREATE TABLE Employee ( 
EmployeeID INT PRIMARY KEY, 
FirstName VARCHAR(100) NOT NULL, 
LastName VARCHAR(100) NOT NULL, 
DoB DATETIME NOT NULL, 
Gender VARCHAR(50) NOT NULL, 
HireDate DATETIME NOT NULL, 
DepartmentID INT NOT NULL, 
Salary DECIMAL(10, 2) NOT NULL, 
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID) 
);

-- Create Projects Table 
CREATE TABLE Projects ( 
ProjectID INT PRIMARY KEY, 
ProjectName VARCHAR(100) NOT NULL, 
StartDate DATETIME NOT NULL, 
EndDate DATETIME NOT NULL, 
DepartmentID INT NOT NULL,
FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID) 
);

INSERT INTO Departments (DepartmentID, DepartmentName, ManagerID, Location) 
VALUES  
(1, 'IT', 101, 'New York'), 
(2, 'HR', 102, 'San Francisco'), 
(3, 'Finance', 103, 'Los Angeles'), 
(4, 'Admin', 104, 'Chicago'), 
(5, 'Marketing', 105, 'Miami'); 

INSERT INTO Employee (EmployeeID, FirstName, LastName, DoB, Gender, HireDate, DepartmentID, 
Salary) 
VALUES  
(101, 'John', 'Doe', '1985-04-12', 'Male', '2010-06-15', 1, 75000.00), 
(102, 'Jane', 'Smith', '1990-08-24', 'Female', '2015-03-10', 2, 60000.00), 
(103, 'Robert', 'Brown', '1982-12-05', 'Male', '2008-09-25', 3, 82000.00), 
(104, 'Emily', 'Davis', '1988-11-11', 'Female', '2012-07-18', 4, 58000.00), 
(105, 'Michael', 'Wilson', '1992-02-02', 'Male', '2018-11-30', 5, 67000.00); 

INSERT INTO Projects (ProjectID, ProjectName, StartDate, EndDate, DepartmentID) 
VALUES  
(201, 'Project Alpha', '2022-01-01', '2022-12-31', 1), 
(202, 'Project Beta', '2023-03-15', '2024-03-14', 2), 
(203, 'Project Gamma', '2021-06-01', '2022-05-31', 3), 
(204, 'Project Delta', '2020-10-10', '2021-10-09', 4), 
(205, 'Project Epsilon', '2024-04-01', '2025-03-31', 5);

--Part – A 

--1. Create Stored Procedure for Employee table As User enters either First Name or Last Name and based 
--on this you must give EmployeeID, DOB, Gender & Hiredate. 
create or alter procedure pr_Emp_details
@FirstName varchar(20) = null,
@LastName varchar(20) = null
as
begin
select EmployeeID,DoB,Gender,HireDate from Employee
where FirstName=@FirstName or LastName=@LastName
end

exec pr_Emp_details '','Doe'

--2 Create a Procedure that will accept Department Name and based on that gives employees list who 
--belongs to that department.
create procedure pr_dep_details
@Dname varchar(50)
as 
select  * from Departments join Employee on Departments.DepartmentID = Employee.DepartmentID  where DepartmentName = @Dname

exec pr_dep_details 'IT'


--.  Create a Procedure that accepts Project Name & Department Name and based on that you must give 
--all the project related details. 

create procedure pr_project_Details
@Pname varchar(20),
@Dname varchar(20)
as
select * from Projects join Departments on projects.DepartmentID = Departments.DepartmentID where ProjectName=@Pname or DepartmentName=@Dname

exec pr_project_Details 'Project Beta','IT'


--4. Create a procedure that will accepts any integer and if salary is between provided integer, then those 
--employee list comes in output.  
create procedure pr_emp_salaryDetails
@Minsalary Decimal(10, 2),
@Maxsalary Decimal(10,2)
as 
select * from Employee where salary between @Minsalary and @Maxsalary 

exec pr_emp_salaryDetails 10000,75000

--5. Create a Procedure that will accepts a date and gives all the employees who all are hired on that date.  
create procedure pr_emp_hiredDetails
@HDate DateTime
as 
select * from Employee where HireDate = @HDate

exec pr_emp_hiredDetails '2010-06-15'

--Part – B 
--6. Create a Procedure that accepts Gender’s first letter only and based on that employee details will be 
--served.  
create or alter procedure pr_emp_datailsFromGender
@Gend  VARCHAR(50)
as
select * from Employee where Gender Like @Gend+'%'

exec pr_emp_datailsFromGender 'f'




--7. Create a Procedure that accepts First Name or Department Name as input and based on that employee 
--data will come.  
create procedure pr_depEmp_details
@Dname varchar(50),
@Fname varchar(50)
as 
select  * from Departments join Employee on Departments.DepartmentID = Employee.DepartmentID  where DepartmentName = @Dname or FirstName = @Fname

exec pr_depEmp_details 'IT','Robert'

--8. Create a procedure that will accepts location, if user enters a location any characters, then he/she will 
--get all the departments with all data. 
create procedure pr_dep_DetailsFromLocation
@Locat varchar(50)
as 
select * from Departments join Employee on Departments.DepartmentID=employee.DepartmentID where Location=@Locat

exec pr_dep_DetailsFromLocation 'Los Angeles'

--Part – C 
--9. Create a procedure that will accepts From Date & To Date and based on that he/she will retrieve Project 
--related data. 
create or alter procedure pr_pro_ProjectDetailsFromTO
@startDate DateTime,
@EndDate datetime
as 
select * from Projects where StartDate=@startDate and EndDate= @EndDate 

exec  pr_pro_ProjectDetailsFromTO '2022-01-01','2022-12-31'

--10. Create a procedure in which user will enter project name & location and based on that you must 
--provide all data with Department Name, Manager Name with Project Name & Starting Ending Dates. 
create or alter procedure pr_pro_getDetailsFromlocationandpro
@Projname varchar(50),
@Loct varchar(30)
as
begin
select departments.DepartmentName,employee.FirstName,Projects.ProjectName from Projects join departments on Projects.departmentId = departments.departmentId
join employee on departments.DepartmentID = employee.DepartmentID where projects.ProjectName=@Projname and departments.Location=@Loct
end 

exec pr_pro_getDetailsFromlocationandpro 'Project Alpha','New York'