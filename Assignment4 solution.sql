
--1
CREATE VIEW View_Product_Order_Gaddam
AS
SELECT ProductName,SUM(Quantity) As TotalOrderQty FROM [Order Details] OD JOIN Products P ON P.ProductID = OD.ProductID
GROUP BY ProductName

--2

ALTER PROC sp_Product_Order_Quantity_Gaddam
@ProductID INT,
@TotalOrderQty INT OUT
AS
BEGIN
SELECT @TotalOrderQty = SUM(Quantity)  FROM [Order Details] OD JOIN Products P ON P.ProductID = OD.ProductID
WHERE P.ProductID = @ProductID
END



DECLARE @Tot INT
EXEC sp_Product_Order_Quantity_Gaddam 11,@Tot OUT
PRINT @Tot 

--3
ALTER PROC sp_Product_Order_City_Gaddam
@ProductName NVARCHAR(50)
AS
BEGIN
SELECT TOP 5 ShipCity,SUM(Quantity) FROM [Order Details] OD JOIN Products P ON P.ProductID = OD.ProductID JOIN Orders O ON O.OrderID = OD.OrderID
WHERE ProductName=@ProductName
GROUP BY ProductName,ShipCity
ORDER BY SUM(Quantity) DESC
END


EXEC sp_Product_Order_City_Gaddam 'Queso Cabrales'


--4
CREATE TABLE People_Gaddam
(
id int ,
name nvarchar(100),
city int
)

create table City_Gaddam
(
id int,
city nvarchar(100)
)
BEGIN TRAN 
insert into City_Gaddam values(1,'Seattle')
insert into City_Gaddam values(2,'Green Bay')

insert into People_Gaddam values(1,'Aaron Rodgers',1)
insert into People_Gaddam values(2,'Russell Wilson',2)
insert into People_Gaddam values(3,'Jody Nelson',2)

if exists(select id from People_Gaddam where city = (select id from City_Gaddam where city = 'Seatle'))
begin
insert into City_Gaddam values(3,'Madison')
update People_Gaddam
set city = 'Madison'
where id in (select id from People_Gaddam where city = (select id from City_Gaddam where city = 'Seatle'))
end
delete from City_Gaddam where city = 'Seattle'

CREATE VIEW Packers_Gaddam
AS
SELECT name FROM People_Gaddam WHERE city = 'Green Bay'

select * from Packers_Gaddam
commit
drop table People_Gaddam
drop table City_Gaddam
drop view Packers_Gaddam

-- 5

ALTER PROC sp_birthday_employee_gaddam
AS
BEGIN
SELECT * INTO #EmployeeTemp
FROM Employees WHERE DATEPART(MM,BirthDate) = 02
SELECT * FROM #EmployeeTemp
END



--6 USE EXCEPT KEYWORD

SELECT * FROM Customers
EXCEPT
SELECT * FROM Customers

--7 SELECT firstName+' '+lastName from Person where middleName is null UNION SELECT firstName+' '+lastName+' '+middelName+'.' from Person where middleName is not null

--8 select top 1 marks from student where sex = 'F' order by marks desc

--9 select * from students order by sex,marks