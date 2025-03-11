--  Create the Products table 
CREATE TABLE Products ( 
Product_id INT PRIMARY KEY, 
Product_Name VARCHAR(250) NOT NULL, 
Price DECIMAL(10, 2) NOT NULL 
); 


--  Insert data into the Products table 
INSERT INTO Products (Product_id, Product_Name, Price) VALUES 
(1, 'Smartphone', 35000), 
(2, 'Laptop', 65000), 
(3, 'Headphones', 5500), 
(4, 'Television', 85000), 
(5, 'Gaming Console', 32000);

--From the above given tables perform the following queries:  
--Part - A 
--1. Create a cursor Product_Cursor to fetch all the rows from a products table. 
DECLARE @Product_id INT, @Product_Name VARCHAR(200), @Price INT;
DECLARE Product_Cursor CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products;
OPEN Product_Cursor;
FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @Product_id AS Product_ID, @Product_Name AS Product_Name, @Price AS Price;
	FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
END;
CLOSE Product_Cursor;
DEALLOCATE Product_Cursor;



--2. Create a cursor Product_Cursor_Fetch to fetch the records in form of ProductID_ProductName. 
--(Example: 1_Smartphone) 
declare @productInfo varchar(300)
declare Product_Curser_fetch cursor
for select 
		cast(Product_id as varchar) + '-'+ Product_Name as ProductInfo
from Products
open  Product_Curser_fetch
fetch next from Product_Curser_fetch into @productInfo
while @@FETCH_STATUS=0
begin 
	print @ProductInfo
	fetch next from Product_Curser_fetch into @productInfo
end
close Product_Curser_fetch
deallocate Product_Curser_fetch

--3. Create a Cursor to Find and Display Products Above Price 30,000. 
Declare @product_id int,@Product_name varchar(200),@Price int ;
DECLARE Product_Cursor_findPrice CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products where Price > 30000;
OPEN Product_Cursor_findPrice;
FETCH NEXT FROM Product_Cursor_findPrice INTO @Product_id, @Product_Name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @Product_id AS Product_ID, @Product_Name AS Product_Name, @Price AS Price;
	FETCH NEXT FROM Product_Cursor_findPrice INTO @Product_id, @Product_Name, @Price;
END;
CLOSE Product_Cursor_findPrice;
DEALLOCATE Product_Cursor_findPrice;
--4. Create a cursor Product_CursorDelete that deletes all the data from the Products table. 
Declare @product_id INT
DECLARE Product_CursorDelete CURSOR
FOR
    SELECT Product_id
    FROM Products
OPEN Product_CursorDelete;
FETCH NEXT FROM Product_CursorDelete INTO @Product_id
WHILE @@FETCH_STATUS = 0
BEGIN
    Delete from Products where Product_id = @Product_id
	FETCH NEXT FROM Product_CursorDelete INTO @Product_id
END;
CLOSE Product_CursorDelete;
DEALLOCATE Product_CursorDelete;
--Part – B 
--5. Create a cursor Product_CursorUpdate that retrieves all the data from the products table and increases 
--the price by 10%. 
DECLARE @product_id INT, @Product_name VARCHAR(200), @Price DECIMAL(10, 2);
DECLARE Product_CursorUpdate CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products;
OPEN Product_CursorUpdate;
FETCH NEXT FROM Product_CursorUpdate INTO @product_id, @Product_name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    UPDATE Products
    SET Price = @Price * 1.1
    WHERE Product_id = @product_id;
    FETCH NEXT FROM Product_CursorUpdate INTO @product_id, @Product_name, @Price;
END;
CLOSE Product_CursorUpdate;
DEALLOCATE Product_CursorUpdate;

--6. Create a Cursor to Rounds the price of each product to the nearest whole number. 
DECLARE @product_id INT, @Product_name VARCHAR(200), @Price int;
DECLARE Product_CursorUpdate CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products;
OPEN Product_CursorUpdate;
FETCH NEXT FROM Product_CursorUpdate INTO @product_id, @Product_name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    SELECT @Product_id AS Product_ID, @Product_Name AS Product_Name,ROUND(@Price,5) AS Price;
    FETCH NEXT FROM Product_CursorUpdate INTO @product_id, @Product_name, @Price;
END;
CLOSE Product_CursorUpdate;
DEALLOCATE Product_CursorUpdate
--Part – C 
--7. Create a cursor to insert details of Products into the NewProducts table if the product is “Laptop” 
--(Note: Create NewProducts table first with same fields as Products table) 
CREATE TABLE NEWProducts ( 
Product_id INT PRIMARY KEY, 
Product_Name VARCHAR(250) NOT NULL, 
Price DECIMAL(10, 2) NOT NULL 
); 

DECLARE @Product_id INT, @Product_Name VARCHAR(200), @Price INT;
DECLARE Product_Cursor CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products where product_name = 'Laptop';
OPEN Product_Cursor;
FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    insert into NEWProducts values(@Product_id,@Product_Name,@price)
	FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
END;
CLOSE Product_Cursor;
DEALLOCATE Product_Cursor;

--8. Create a Cursor to Archive High-Price Products in a New Table (ArchivedProducts), Moves products 
--with a price above 50000 to an archive table, removing them from the original Products table. 
CREATE TABLE ArchivedProducts ( 
Product_id INT PRIMARY KEY, 
Product_Name VARCHAR(250) NOT NULL, 
Price DECIMAL(10, 2) NOT NULL 
); 

DECLARE @Product_id INT, @Product_Name VARCHAR(200), @Price INT;
DECLARE Product_Cursor CURSOR
FOR
    SELECT Product_id, Product_Name, Price
    FROM Products where price > 50000;
OPEN Product_Cursor;
FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
WHILE @@FETCH_STATUS = 0
BEGIN
    insert into ArchivedProducts values(@Product_id,@Product_Name,@price)
	delete from products where Product_id = @Product_id
	FETCH NEXT FROM Product_Cursor INTO @Product_id, @Product_Name, @Price;
END;
CLOSE Product_Cursor;


select * from ArchivedProducts