use AdventureWorks2019
go 

--1.      How many products can you find in the Production.Product table?
SELECT COUNT(*) Total
FROM Production.Product

--  !!!! make sure differenc btw * and productId

/*2. Write a query that retrieves the number of products in the Production.Product table that are included in a subcategory. 
--The rows that have NULL in column ProductSubcategoryID are considered to not be a part of any subcategory.*/
SELECT COUNT(*) 
FROM Production.Product
WHERE ProductSubcategoryID IS NOT NULL

-- if one table is involved, then is alias and reference to table name is necessary?????


--3 How many Products reside in each SubCategory? Write a query to display the results with the following titles.

/*ProductSubcategoryID CountedProducts

-------------------- ---------------*/
SELECT ProductSubcategoryID, COUNT(Name) CountedProducts
FROM Production.Product
WHERE ProductSubcategoryID is not NULL
GROUP BY ProductSubcategoryID

-- att: when realted to kinds/types, always use count of ID. 
--4 How many products that do not have a product subcategory.
SELECT COUNT(*)
FROM Production.Product 
WHERE ProductSubcategoryID IS NULL 

--5 Write a query to list the sum of products quantity in the Production.ProductInventory table.
SELECT SUM(Quantity)
FROM Production.ProductInventory
GROUP BY ProductID;
--6 
/* Write a query to list the sum of products in the Production.ProductInventory table and LocationID set to 40 
and limit the result to include just summarized quantities less than 100.

              ProductID    TheSum

              -----------        ----------
*/
SELECT ProductId, SUM(Quantity) TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID
HAVING SUM(Quantity) < 100

--7
/* Write a query to list the sum of products with the shelf information in the Production.ProductInventory table 
and LocationID set to 40 and limit the result to include just summarized quantities less than 100

    Shelf      ProductID    TheSum

    ----------   -----------        ----------- */
SELECT Shelf, ProductId, SUM(Quantity) TheSum
FROM Production.ProductInventory
WHERE LocationID = 40
GROUP BY ProductID, Shelf
HAVING SUM(Quantity) < 100


--8 
/*Write the query to list the average quantity for products where column LocationID has the value of 10 
from the table Production.ProductInventory table. */
SELECT ProductID, AVG(Quantity) 
FROM Production.ProductInventory
WHERE LocationID = 10 
GROUP BY ProductID


--9 
/* Write query  to see the average quantity  of  products by shelf  from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

    ----------- ---------- -----------*/
SELECT ProductID, Shelf, AVG(Quantity) TheAvg
FROM Production.ProductInventory
GROUP BY ProductID, Shelf


--10 
/*
Write query  to see the average quantity  of  products by shelf excluding rows that has the value of N/A 
in the column Shelf from the table Production.ProductInventory

    ProductID   Shelf      TheAvg

----------- ---------- -----------
*/
SELECT ProductID, Shelf, AVG(Quantity) TheAvg
FROM Production.ProductInventory
WHERE Shelf != 'N/A'
GROUP BY ProductID, Shelf


--11   
/*
List the members (rows) and average list price in the Production.Product table. 
This should be grouped independently over the Color and the Class column. Exclude the rows where Color or Class are null.

    Color                        Class              TheCount          AvgPrice

    -------------- - -----    -----------            ---------------------
*/
SELECT Color, Class, COUNT(*) TheCount, AVG(ListPrice) AvgPrice
FROM Production.Product
WHERE Color is not null AND Class is not null
GROUP BY Color, Class



--12 
/*Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables. Join them and produce a result set similar to the following.

    Country                        Province

    ---------                          ----------------------
*/
SELECT cr.Name Country, sp.Name Province
FROM Person.CountryRegion cr INNER JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode


--13 
/*
Write a query that lists the country and province names from person. CountryRegion and person. StateProvince tables and 
list the countries filter them by Germany and Canada. Join them and produce a result set similar to the following.

 

    Country                        Province

    ---------                          ----------------------
*/
SELECT cr.Name Country, sp.Name Province
FROM Person.CountryRegion cr INNER JOIN Person.StateProvince sp ON cr.CountryRegionCode = sp.CountryRegionCode
WHERE cr.Name in ('Germany', 'Canada')


--????? filter by means we want that filter condition or not ???



USE Northwind
GO  


--14 List all Products that has been sold at least once in last 25 years.
-- ONLY WANT ID OR WHAT?
DECLARE @@25YearsAgo DATETIME;
SELECT @@25YearsAgo = DATEADD(year, -25, GETDATE());


-- if we ONLY want the ProductID
SELECT  DISTINCT OD.ProductID
FROM Orders O INNER JOIN [Order Details] OD  ON O.OrderID = OD.OrderID INNER JOIN Products P ON OD.ProductID = P.ProductID
WHERE O.OrderDate > @@25YearsAgo


-- if we want all information of products, we can SELECT * FROM those productID  
SELECT * 
FROM Products
WHERE ProductID IN
(SELECT DISTINCT OD.ProductID
FROM Orders O INNER JOIN [Order Details] OD  ON O.OrderID = OD.OrderID INNER JOIN Products P ON OD.ProductID = P.ProductID
WHERE O.OrderDate > @@25YearsAgo)


--15 List top 5 locations (Zip Code) where the products sold most.

SELECT TOP 5 O.ShipPostalCode
FROM Orders O INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
WHERE O.ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode
ORDER BY SUM(OD.Quantity)  DESC


--16 List top 5 locations (Zip Code) where the products sold most in last 25 years. 

-- @@25YearsAgo defined in question 14
-- did not specify if we should include ShipPostalCode is null or not, so i just assumed we only want valid ShipPostalCode which has more real life meaning
SELECT TOP 5 O.ShipPostalCode
FROM Orders O INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID
WHERE O.OrderDate > @@25YearsAgo AND O.ShipPostalCode IS NOT NULL
GROUP BY ShipPostalCode
ORDER BY  SUM(OD.Quantity)  DESC



--17.   List all city names and number of customers in that city.     
SELECT  City, count(CustomerID) NbOfCustomers
FROM Customers 
GROUP BY City


--18.  List city names which have more than 2 customers, and number of customers in that city
SELECT  City, count(CustomerID) NbOfCustomers
FROM Customers 
GROUP BY City
HAVING COUNT(CustomerID) > 2


--19.  List the names of customers who placed orders after 1/1/98 with order date.
SELECT  DISTINCT C.ContactName, O.OrderDate
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
WHERE O.OrderDate > '1998-01-01'

-- distinct, no dupliactes

--20.  List the names of all customers with most recent order dates????
-- with most recent OrderDate of each customer
SELECT C.ContactName, MAX(O.OrderDate) MostRecentOrderDate
FROM Customers C INNER JOIN Orders O ON C.CustomerID = O.CustomerID 
GROUP BY C.ContactName

-- ???? specify the requirments, null for customers with no orders 
-- or disregard those customers


--21.  Display the names of all customers  along with the  count of products they bought

SELECT C.ContactName, sum(OD.Quantity) TotalProductBought
FROM [Order Details] OD INNER JOIN  Orders O ON O.OrderID = OD.OrderID RIGHT JOIN Customers C ON O.CustomerID = C.CustomerID
GROUP BY C.ContactName

-- shuold include all customers, even if they do not have any orders.


--22.  Display the customer ids who bought more than 100 Products with count of products.

SELECT O.CustomerID
FROM Orders O INNER JOIN [Order Details] OD ON O.OrderID = OD.OrderID INNER JOIN Customers C ON O.CustomerID = C.CustomerID
GROUP BY O.CustomerID
HAVING sum(OD.Quantity) > 100


--23.  List all of the possible ways that suppliers can ship their products. Display the results as below
--
--    Supplier Company Name                Shipping Company Name
--
--    ---------------------------------            ----------------------------------
SELECT S.CompanyName, Sh.CompanyName
FROM Suppliers S CROSS JOIN Shippers Sh
 

--24.  Display the products order each day. Show Order date and Product Name.
-- DO WE NEED 
SELECT O.OrderDate, P.ProductName
FROM [Order Details] OD INNER JOIN Orders O ON O.OrderID = OD.OrderID RIGHT JOIN Products P ON OD.ProductID = P.ProductID
GROUP BY O.OrderDate, P.ProductName

-- when not specify, include all products even if no order of such products ????
--25.  Displays pairs of employees who have the same job title.
SELECT E.FirstName + E.LastName Employee1, EE.FirstName + EE.LastName Employee2
FROM Employees E INNER JOIN Employees EE ON E.Title = EE.Title 
WHERE E.EmployeeID != EE.EmployeeID


--26.  Display all the Managers who have more than 2 employees reporting to them.

SELECT M.EmployeeID ManagerEmployeeID
FROM Employees E INNER JOIN Employees  M ON E.ReportsTo = M.EmployeeID
GROUP BY M.EmployeeID
HAVING COUNT(E.EmployeeID) > 2

-- count here will disregard null values???
--27.  Display the customers and suppliers by city. The results should have the following columns ???? what is Name????
--
--City
--
--Name?? CompanyName??
--
--Contact Name,
--
--Type (Customer or Supplier)


(SELECT City, CompanyName, ContactName, 'Customer' Type
FROM Customers )
UNION All
(SELECT City, CompanyName, ContactName, 'Supplier' Type 
FROM Suppliers)
ORDER BY CITY


