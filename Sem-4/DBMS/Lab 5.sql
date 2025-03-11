-- Creating PersonInfo Table 
CREATE TABLE PersonInfo ( 
PersonID INT PRIMARY KEY, 
PersonName VARCHAR(100) NOT NULL, 
Salary DECIMAL(8,2) NOT NULL, 
JoiningDate DATETIME NULL, 
City VARCHAR(100) NOT NULL, 
Age INT NULL, 
BirthDate DATETIME NOT NULL 
); 



-- Creating PersonLog Table 
CREATE TABLE PersonLog ( 
PLogID INT PRIMARY KEY IDENTITY(1,1), 
PersonID INT NOT NULL, 
PersonName VARCHAR(250) NOT NULL, 
Operation VARCHAR(50) NOT NULL, 
UpdateDate DATETIME NOT NULL, 
); 

drop table PersonLog


--Part – A 
--1. Create a trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo table to display 
--a message “Record is Affected.”  
create trigger TR_PersonInfo_DisplayMessage
on personInfo
after insert , update , delete 
as
begin 
print 'Record is Affected.'
end 

insert into PersonInfo values(101,'namra',12000,'2025-2-24','gondal',20,'2005-2-24')

drop  trigger TR_PersonInfo_DisplayMessage

--2. Create a trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo table. For that, 
--log all operations performed on the person table into PersonLog. 

--insert
create or alter trigger TR_StoreInLog_INS
on PersonInfo
after insert
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'insert'
	select @PerId = PersonID,@PerName=PersonName from inserted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

insert into PersonInfo values(106,'asdf',12000,'2025-2-24','gondal',20,'2005-2-24')

select * from PersonLog
select * from PersonInfo

--update
create or alter trigger TR_StoreInLog_INS
on PersonInfo
after update
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'update'
	select @PerId = PersonID,@PerName=PersonName from inserted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

update PersonInfo set PersonName='dhol' where PersonID=102

select * from PersonLog
select * from PersonInfo

--delete
create or alter trigger TR_StoreInLog_INSDelete
on PersonInfo
after delete
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'delete'
	select @PerId = PersonID,@PerName=PersonName from deleted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

delete from PersonInfo where Personname='asdf'
delete from PersonInfo where PersonID = 106

select * from PersonLog
select * from PersonInfo


--3. Create an INSTEAD OF trigger that fires on INSERT, UPDATE and DELETE operation on the PersonInfo 
--table. For that, log all operations performed on the person table into PersonLog. 

--insert
create or alter trigger TR_StoreInLog_insteadOF_insert
on PersonInfo
INSTEAD OF insert
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'insert'
	select @PerId = PersonID,@PerName=PersonName from inserted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

insert into PersonInfo values(1,'lkjh',12000,'2025-2-24','gondal',20,'2005-2-24')

select * from PersonLog
select * from PersonInfo

--update
create or alter trigger StoreInLog_insteadOF_update
on PersonInfo
INSTEAD OF update
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'update'
	select @PerId = PersonID,@PerName=PersonName from inserted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

update PersonInfo set PersonName='qwert' where PersonID=102

select * from PersonLog
select * from PersonInfo


--delete
create or alter trigger StoreInLog_insteadOF_delete
on PersonInfo
INSTEAD OF delete
as
begin
	declare @PerId int
	declare @PerName varchar(50)
	declare @Operation varchar(50)
	declare @date datetime
	set @date = GETDATE()
	set @Operation = 'delete'
	select @PerId = PersonID,@PerName=PersonName from deleted
	insert into PersonLog values
	(@PerId,@PerName,@Operation,@date)
end

delete from PersonInfo where PersonID=102
select * from PersonLog
select * from PersonInfo

--4. Create a trigger that fires on INSERT operation on the PersonInfo table to convert person name into 
--uppercase whenever the record is inserted. 
CREATE or alter TRIGGER TR_PersonInfo_UppercaseName
ON PersonInfo
after INSERT
AS
BEGIN
    UPDATE PersonInfo
    SET PersonName = UPPER(i.PersonName)
    FROM inserted i
    WHERE PersonInfo.PersonID = i.PersonID
END

insert into PersonInfo values(110,'namra',12000,'2025-2-24','gondal',20,'2005-2-24')

select * from PersonInfo
drop TRIGGER TR_PersonInfo_UppercaseName
--5. Create trigger that prevent duplicate entries of person name on PersonInfo table. 
CREATE OR ALTER TRIGGER TR_PersonInfo_PreventDuplicateName
ON PersonInfo
INSTEAD OF INSERT
AS
BEGIN
    INSERT INTO PersonInfo (PersonID, PersonName, Salary, JoiningDate, City, Age, BirthDate)
    SELECT 
        PersonID, 
        PersonName, 
        Salary, 
        JoiningDate, 
        City, 
        Age, 
        BirthDate
    FROM inserted
    WHERE PersonName NOT IN (SELECT PersonName FROM PersonInfo);
END;

insert into PersonInfo values(125,'efvb',12000,'2025-2-24','gondal',20,'2005-2-24')

select * from PersonInfo

--6. Create trigger that prevent Age below 18 years.
Create Trigger Tr_PersonInfo_PreventUnderAge
On PersonInfo
Instead Of Insert
As
Begin
	Insert Into PersonInfo
	Select 
		PersonID,
		PersonName,
		Salary,
		JoiningDate,
		City ,
		Age,
		BirthDate
	From inserted
	WHERE Age>=18
End

Insert Into PersonInfo values(2,'Rahul',82367,'1991-03-24','Rajkot',34,'1990-03-24')

Insert Into PersonInfo values(78,'sdg',82367,'1991-03-24','Rajkot',11,'1990-03-24')

select *from PersonInfo
drop Trigger Tr_PersonInfo_PreventUnderAge
--Part – B 
--7. Create a trigger that fires on INSERT operation on person table, which calculates the age and update 
--that age in Person table. 
create 

--8. Create a Trigger to Limit Salary Decrease by a 10%. 
--Part – C  
--9. Create Trigger to Automatically Update JoiningDate to Current Date on INSERT if JoiningDate is NULL 
--during an INSERT. 
--10. Create DELETE trigger on PersonLog table, when we delete any record of PersonLog table it prints 
--‘Record deleted successfully from PersonLog’.