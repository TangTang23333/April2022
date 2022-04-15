use AdventureWorks2019
go

--1
select ProductID, Name, Color, ListPrice
from Production.Product

--2
select ProductID, Name, Color, ListPrice
from Production.Product
where ListPrice = 0 


--3
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is Null


--4
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not Null 


--5
select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not Null AND ListPrice > 0


--6
select 'Name: ' + Name +  ' -- COLOR: ' + Color
from Production.Product
where Color is not Null


--7
select Name, Color
from Production.Product
where color in ('Black', 'Silver')


--8
select ProductID, Name
from Production.Product
where ProductID BETWEEN 400 and 500


--9
select ProductID, Name
from Production.Product
where color in ('Black', 'Blue')


--10
select *
from Production.Product
where Name like 'S%'


--11
select Name, ListPrice
from Production.Product
where Name like 'S%'
order by Name

--12
select Name, ListPrice
from Production.Product
where Name like '[AS]%'
order by Name


--13
select *
from Production.Product
where Name like 'SPO[^K]%'
order by Name


--14
select distinct Color
from Production.Product
order by  Color desc


--15
select distinct ProductSubcategoryID,  Color
from Production.Product
where Color is not null And ProductSubcategoryID is not null