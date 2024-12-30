--Part – A 
--1. Write a function to print "hello world". 
	create or alter function FN_HelloWorld()
	Returns varchar(50)
	as
	begin 
		return 'hello world'
	End

	select dbo.FN_HelloWorld()

--2. Write a function which returns addition of two numbers. 
		create or alter Function Fn_add_Number(@num1 int,@num2 int)
		returns int
		as 
		begin 
			return @num1+@num2
		end

		select dbo.fn_add_Number(2,5)

--3. Write a function to check whether the given number is ODD or EVEN. 
		create or alter Function fn_Find_OddEven(@num int)
		returns varchar(25)
		as 
		begin 
			declare @msg varchar(25)
			if @num % 2 = 0
				set @msg = 'even'
			else 
				set @msg = 'odd'
			return @msg
		end

		select dbo.fn_Find_OddEven(21)

--4. Write a function which returns a table with details of a person whose first name starts with B. 
	create or alter Function Fn_PersonTable()
	returns table
	as
		return select * from Person where FirstName like 'B%'

	select * from  dbo.Fn_personTable()
--5. Write a function which returns a table with unique first names from the person table. 
	create or alter Function Fn_unique_FName()
	returns table
	as
		return select distinct firstname from Person

	select * from  dbo.Fn_unique_FName()
--6. Write a function to print number from 1 to N. (Using while loop) 
	create or alter Function Fn_PrintNumber(@num int)
	returns varchar(100)
	as
	begin 
		declare @ans varchar(100)='',@i int=1;
		while @i<=@num 
			begin 
				set @ans = @ans + ' ' +cast(@i as varchar(2))
				set @i = @i+1
			end
		return @ans
	end

	select dbo.Fn_PrintNumber(5)
--7. Write a function to find the factorial of a given integer. 
	create or alter Function Fn_Factorial(@num int)
	returns int
	as
	begin 
		declare @ans int = 1,@i int=1;
		while @i<=@num 
			begin 
				set @ans = @ans*@i 
				set @i = @i+1
			end
		return @ans
	end

	select dbo.Fn_Factorial(5)

--	Part – B 
--8. Write a function to compare two integers and return the comparison result. (Using Case statement)
CREATE OR ALTER FUNCTION FN_COMPARE_TWO(@a INT,@b INT)
RETURNS VARCHAR(50)
AS
BEGIN
	RETURN (
		CASE
			WHEN @a>@b THEN 'First is greater than second'
			WHEN @a<@b THEN 'First is less than second'
			ELSE 'Both are equal'
		END
	)
END
SELECT dbo.FN_COMPARE_TWO(2,2)

--9. Write a function to print the sum of even numbers between 1 to 20. 
	create or alter Function fn_sumOfEven(@num int)
		returns int
		as 
		begin 
			declare @ans int = 0,@i int=1;
			while @i<=@num 
			begin
				if @i % 2 = 0
					begin
						set @ans = @ans + @i
						set @i = @i+1
					end
				else 
					set @i = @i+1
			end
			return @ans
		end

	select dbo.Fn_sumOfEven(6)
--10. Write a function that checks if a given string is a palindrome
   create or alter Function FN_StringPalindrom(@str varchar(100))
   returns varchar(100)
   as 
   begin
		declare @ans varchar(50) = ''
		if @str = reverse(@str)
			set @ans = 'palindrom'
		else 
			set @ans = 'not palindrom'
		return @ans
	end

	select dbo.fn_StringPalindrom('aba')

--	Part – C 
--11. Write a function to check whether a given number is prime or not. 
CREATE OR ALTER FUNCTION FN_PRIME(@num INT)
RETURNS VARCHAR(50)
AS
BEGIN
	DECLARE @i int=2,@fact int=0,@msg varchar(50)=''
	while @i<=@num/2
	begin
		IF @num%@i=0
			SET @fact=1
			SET @i=@i+1
	end
	IF @fact=0
		set @msg = 'Is Prime'
	ELSE
		set @msg='Not Prime'
	RETURN @msg
END

select dbo.FN_PRIME(10)

--12. Write a function which accepts two parameters start date & end date, and returns a difference in days. 
CREATE OR ALTER FUNCTION FN_DATEDIFF(@START DATE,@END DATE)
RETURNS INT
AS
BEGIN
	RETURN DATEDIFF(DAY,@START,@END)
END
SELECT dbo.FN_DATEDIFF('2024-11-01','2024-12-24')
--13. Write a function which accepts two parameters year & month in integer and returns total days each year. 
CREATE OR ALTER FUNCTION FN_TOTAL_DAYS(@year INT,@month INT)
RETURNS INT
AS
BEGIN
	DECLARE @ANS INT
	IF @year%4=0 and @month=2
		SET @ANS=29
	ELSE IF @month=2
		SET @ANS=28
	ELSE IF @month%2=0
		SET @ANS=30
	ELSE
		SET @ANS=31
	RETURN @ANS
END
SELECT dbo.FN_TOTAL_DAYS(2024,2)
--14 Write a function which accepts departmentID as a parameter & returns a detail of the persons.
CREATE OR ALTER FUNCTION FN_DETAILS_PERSON(@DeptID INT)
RETURNS TABLE
AS
	RETURN (SELECT * FROM PERSON WHERE DepartmentID=@DeptID)


SELECT * FROM dbo.FN_DETAILS_PERSON(1)


--15 Write a function that returns a table with details of all persons who joined after 1-1-1991.
CREATE OR ALTER FUNCTION FN_AFTERDATE()
RETURNS TABLE
AS
	RETURN (SELECT * FROM PERSON WHERE JoiningDate>'1991-01-01')


