-- Create the Customers table 
CREATE TABLE Customers ( 
Customer_id INT PRIMARY KEY,                 
Customer_Name VARCHAR(250) NOT NULL,         
Email VARCHAR(50) UNIQUE                     
); 

-- Create the Orders table 
CREATE TABLE Orders ( 
Order_id INT PRIMARY KEY,                    
Customer_id INT,                             
Order_date DATE NOT NULL,                    
FOREIGN KEY (Customer_id) REFERENCES Customers(Customer_id)  
);


--1. Handle Divide by Zero Error and Print message like: Error occurs that is - Divide by zero error.
Begin Try
    Declare @n1 Int = 10, @n2 Int = 0, @result Int;
    Set @result = @n1 / @n2;
End Try

Begin Catch
    Print 'Error : Divide by zero error.';
End Catch

--2. Try to convert string to integer and handle the error using try…catch block.
Begin Try
    Declare @str NVARCHAR(10) = 'smit';
    Declare @n Int;
    Set @n = CAST(@str As Int);
End Try

Begin Catch
    Print 'Error : Conversion error.';
End Catch;

--3. Create a procedure that prints the sum of two numbers: take both numbers as integer & handle 
--exception with all error functions if any one enters string value in numbers otherwise print result. 
Create Proc Pr_SumOfTwoNo 
    @num1 Nvarchar(50),
    @num2 Nvarchar(50)
As
Begin
    Declare @number1 Int, @number2 Int;
    
    Begin Try
        Set @number1 = CAST(@number1 As Int);
        Set @number2 = CAST(@number2 As Int);
        PRINT 'Sum is: ' + CAST((@number1 + @number2) As Nvarchar);
    End Try

    Begin Catch
        Print 'Error : Input Type Is Invalid.';
    End Catch;
End;

--4. Handle a Primary Key Violation while inserting data into customers table and print the error details 
--such as the error message, error number, severity, and state. 
Begin Try
    Insert Into Customers (Customer_id, Customer_Name)
    Values (1, 'Smit');
End Try

Begin Catch
    Print 'Error Message: ' + ERROR_MESSAGE();
    Print 'Error Number: ' + CAST(ERROR_NUMBER() As Nvarchar);
    Print 'Severity: ' + CAST(ERROR_SEVERITY() As Nvarchar);
    Print 'State: ' + CAST(ERROR_STATE() As Nvarchar);
End Catch

--5. Throw custom exception using stored procedure which accepts Customer_id as input & that throws 
--Error like no Customer_id is available in database.
Create Proc Pr_CheckCustomerID
    @Customer_id INT
As
Begin
    If NOT EXISTS (Select * From Customers Where Customer_id = @Customer_id)
    Begin
        Throw 51000, 'Customer_id Is Not Available In Database.', 1;
    END

    Else
    Begin
        Print 'Customer Is Exists'
    End
End;
Exec Pr_CheckCustomerID 1




BEGIN TRY
    INSERT INTO Orders (Order_id, Customer_id, Order_date)
    VALUES (1, 999, '2025-02-12');
END TRY
BEGIN CATCH
    PRINT 'Foreign key violation error.';
END CATCH;


CREATE PROC Pr_ValidateData @data Nvarchar(50)
AS
BEGIN
    If @data IS NULL OR @data = ''
    Begin
        Throw 51000, 'Invalid data.', 1;
    End
    Else
    Begin
        Print 'Data is valid.';
    End
End;


CREATE PROC Pr_UpdateCustomerEmail @Customer_id Int, @newEmail Nvarchar(50)
As
Begin
    Begin Try
        UPDATE Customers
        SET Email = @newEmail
        WHERE Customer_id = @Customer_id;
        PRINT 'Email updated successfully.';
    End try

    Begin Catch
        Print 'Error: ' + ERROR_MESSAGE();
        Print 'Error Number: ' + CAST(ERROR_NUMBER() As Nvarchar(50));
        Print 'Severity: ' + CAST(ERROR_SEVERITY() As Nvarchar(50));
        Print 'State: ' + CAST(ERROR_STATE() As Nvarchar(50));
    End Catch
End;
