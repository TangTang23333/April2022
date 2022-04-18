USE Northwind
GO

--1.      Create a view named ¡°view_product_order_[your_last_name]¡±, 
--list all products and total ordered quantity for that product.

CREATE VIEW view_product_order_Tang
AS
SELECT P.ProductID, P.ProductName, SUM(OD.Quantity) TotalProductsSold
FROM [Order Details] OD RIGHT JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY P.ProductID,  P.ProductName;

--SELECT * FROM view_product_order_Tang


--2.      Create a stored procedure ¡°sp_product_order_quantity_[your_last_name]¡± 
--that accept product id as an input and total quantities of order as output parameter.

CREATE PROC sp_product_order_quantity_Tang
@id int,
@total int out
AS
BEGIN
SELECT @total = SUM(Quantity)
FROM [Order Details]
WHERE ProductID = @id
END;


-- test

--declare @totalsold int 
--exec  sp_product_order_quantity_Tang 1, @totalsold out
--select @totalsold



--3.      Create a stored procedure ¡°sp_product_order_city_[your_last_name]¡± 
--that accept product name as an input and top 5 cities that ordered most that product combined 
--with the total quantity of that product ordered from that city as output.

--????? nvarchar two bytes a character, double the space
CREATE PROC sp_product_order_city_Tang 
@PName varchar(30)
AS 
BEGIN
SELECT TOP 5 C.City, SUM(OD.Quantity) TotalProductsOrdered
FROM Customers C INNER JOIN Orders O ON O.CustomerID = C.CustomerID 
INNER JOIN [Order Details] OD ON  OD.OrderID = O.OrderID 
INNER JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ProductName= @PName
GROUP BY C.City,OD.ProductID
ORDER BY SUM(OD.Quantity) DESC
END;



-- test
--BEGIN
-- exec  sp_product_order_city_Tang 'Nord-Ost Matjeshering'
--END


--Nord-Ost Matjeshering
--select productname from products where productid = 30

--4.
--a. Create 2 new tables ¡°people_your_last_name¡± ¡°city_your_last_name¡±. 
--City table has two records: {Id:1, City: Seattle}, {Id:2, City: Green Bay}. 
--People has three records: {id:1, Name: Aaron Rodgers, City: 2}, {id:2, Name: Russell Wilson, City:1}, {Id: 3, Name: Jody Nelson, City:2}. 
--drop table people_Tang
--drop table city_Tang

CREATE TABLE city_Tang(
Id int PRIMARY KEY IDENTITY(1, 1) , 
City varchar(30)
)

CREATE TABLE people_Tang(
Id int PRIMARY KEY IDENTITY(1, 1), 
Name varchar(30),
City int FOREIGN KEY REFERENCES city_Tang(Id) 
)


INSERT INTO city_Tang VALUES
('Seattle')
,('Green Bay')

INSERT INTO people_Tang VALUES
('Aaron Rodgers', 2), 
('Russell Wilson',1),
('Jody Nelson', 2)


--b. Remove city of Seattle. If there was anyone from Seattle, 
--put them into a new city ¡°Madison¡±. 
ALTER TABLE people_Tang
add CONSTRAINT fk_city
FOREIGN KEY (City)
REFERENCES city_Tang(Id)
ON DELETE SET NULL;



--select * from people_Tang;
--select * from city_Tang;

INSERT INTO city_Tang VALUES
('Madison')

UPDATE people_Tang
SET City = (SELECT Id FROM city_Tang WHERE City = 'Madison')
WHERE City = (SELECT Id FROM city_Tang  WHERE City = 'Seattle')

DELETE FROM city_Tang WHERE City = 'Seattle'

--select * from people_Tang
--c. Create a view ¡°Packers_your_name¡± lists all people from Green Bay. 
--If any error occurred, no changes should be made to DB. (after test) Drop both tables and view.
CREATE VIEW Packers_Yihuan_Tang AS
SELECT P.Name
FROM people_Tang P INNER JOIN city_Tang C ON C.Id = P.City
WHERE C.City = 'Green Bay';

--select * from Packers_Yihuan_Tang
-- test done
DROP TABLE people_Tang
DROP TABLE city_Tang
DROP VIEW Packers_Yihuan_Tang



--5.       Create a stored procedure ¡°sp_birthday_employees_[you_last_name]¡± 
--that creates a new table ¡°birthday_employees_your_last_name¡± and fill it 
--with all employees that have a birthday on Feb. (Make a screen shot) drop the table. 
--Employee table should not be affected.
-- 1948-12-08 00:00:00.000
-- ???? add #, tempTable, would only available within the procedure
-- ## available outside the proc, but goes away when the proc is deleted
DROP PROCEDURE sp_birthday_employees_Tang; 
CREATE PROC sp_birthday_employees_Tang
AS 
BEGIN
SELECT EmployeeID,  FirstName , LastName
INTO birthday_employees_Tang
FROM Employees
WHERE MONTH(BirthDate) = 2
END

EXEC sp_birthday_employees_Tang]


--SELECT * FROM birthday_employees_Tang

DROP TABLE birthday_employees_Tang

--6.      How do you make sure two tables have the same data? 
/*
First, make sure that there is no duplicates in both tables.
Then, after removing duplicates, they should have same number of rows.
If not, they  do not have the same data.

Then, I can use inner join two tables, if the result has same row numbers as both tables, 
then they have the same data. Or, i can Union two tables, if the result row numbers is as 
same as two tables, then they have same data. 
*/