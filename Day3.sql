USE Northwind
GO



--1. List all cities that have both Employees and Customers.
-- use join 
SELECT DISTINCT E.City
FROM Employees  E INNER JOIN Customers C ON E.City = C.City 

-- OR USE INTERSECT to get the intersection 
SELECT DISTINCT city from Employees
INTERSECT 
SELECT DISTINCT city from Customers


--2.      List all cities that have Customers but no Employee.
--SELECT DISTINCT CITY FROM Customers
--a.      Use sub-query
SELECT DISTINCT City 
FROM Customers 
WHERE City NOT IN  (SELECT DISTINCT City FROM Employees)

--b.      Do not use sub-query
SELECT DISTINCT C.City
FROM Employees  E RIGHT JOIN Customers C ON E.City = C.City 
WHERE E.City IS NULL

--3. List all products and their total order quantities throughout all orders.
-- if just productID and TotalQuantitySold is required 
SELECT ProductID, SUM(Quantity) TotalQuantityOrdered
FROM [Order Details] 
GROUP BY ProductID

--4.      List all Customer Cities and total products ordered by that city.
--
SELECT C.City, SUM(OD.Quantity) TotalQuantityOrdered
FROM [Order Details] OD RIGHT JOIN Orders O ON OD.OrderID = O.OrderID INNER JOIN Customers C ON C.CustomerID = O.CustomerID
GROUP BY C.City

--5.      List all Customer Cities that have at least two customers. ????
-- direct approach
SELECT City, COUNT(CustomerID) NbOfCustomer
FROM Customers 
GROUP BY City
HAVING COUNT(CustomerID) >= 2
--a.      Use union
-- except 0 and 1 , union 0 and 1 

--b.      Use sub-query and no union
-- except 0 and 1 , not using union for 0 and 1 but subquery
--6.      List all Customer Cities that have ordered at least two different kinds of products.
-- CHECKED 
SELECT C.City,  Count(DISTINCT OD.ProductID) KindsOfProducts
FROM Customers C INNER JOIN Orders O ON O.CustomerID = C.CustomerID INNER JOIN [Order Details] OD  ON OD.OrderID = O.OrderID
GROUP BY C.City
HAVING Count(DISTINCT OD.ProductID) >= 2



--7.      List all Customers who have ordered products, but have the ¡®ship city¡¯ on the order different from their own customer cities.
-- 
SELECT DISTINCT C.CustomerID, C.City, O.ShipCity
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID
WHERE C.City != O.ShipCity 
 

--8.      List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
--

WITH PopularTop5 
AS 
(
SELECT TOP 5 ProductID, AVG(UnitPrice) AvgPrice
FROM [Order Details]
GROUP BY ProductID
ORDER BY SUM(Quantity) DESC 
)

SELECT dt.ProductID, dt.AvgPrice, dt.City, dt.TotalSold
FROM (SELECT OD.ProductID, P5.AvgPrice, C.City, SUM(OD.Quantity) TotalSold, RANK() OVER (Partition BY OD.ProductID Order by SUM(OD.Quantity) DESC ) AS OrderRank
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID INNER JOIN [Order Details] OD ON OD.OrderID = O.OrderID INNER JOIN PopularTop5 P5 ON P5.ProductID = OD.ProductID
GROUP BY OD.ProductID, C.City, P5.AvgPrice) dt
WHERE dt.OrderRank = 1 



--9.      List all cities that have never ordered something but we hav e employees there.
--

--a.      Use sub-query
--
SELECT C.City, COUNT(O.OrderID) NbOfOrder
FROM Customers C LEFT JOIN Orders O ON O.CustomerID = C.CustomerID
WHERE C.City IN (SELECT DISTINCT City FROM Employees)
GROUP BY C.City
HAVING COUNT(O.OrderID) = 0 


--b.      Do not use sub-query
-- USE JOIN 
SELECT C.City, COUNT(O.OrderID) NbOfOrder
FROM Customers C LEFT JOIN Orders O ON O.CustomerID = C.CustomerID INNER JOIN Employees E ON E.City = C.City
GROUP BY C.City
HAVING COUNT(O.OrderID) = 0 ;


--10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)
--ISNULL(col2,0)

SELECT T1.City
FROM (
-- city with most orders
SELECT TOP 1 C.City
FROM Customers C LEFT JOIN Orders O ON O.CustomerID = C.CustomerID
GROUP BY C.City
ORDER BY COUNT(O.OrderID) DESC) T1 

INNER JOIN 
-- city with most products ordered
(SELECT TOP 1 C.City
FROM Customers C INNER JOIN Orders O ON O.CustomerID = C.CustomerID INNER JOIN [Order Details] OD ON OD.OrderID = O.OrderID
GROUP BY C.City
ORDER BY SUM(OD.Quantity) DESC) T2 

ON T1.City = T2.City;


--11. How do you remove the duplicates record of a table?


/*
we can use distinct * to only get the table without duplicates. 

we can also use group by or row_number to find duplicates and then delete the duplicates.
*/ 