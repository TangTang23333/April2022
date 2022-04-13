use AdventureWorks2019
go


select ProductID, Name, Color, ListPrice
from Production.Product


select ProductID, Name, Color, ListPrice
from Production.Product
where ListPrice = 0 



select ProductID, Name, Color, ListPrice
from Production.Product
where Color is Null



select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not Null 



select ProductID, Name, Color, ListPrice
from Production.Product
where Color is not Null AND ListPrice > 0



select 'Name: ' + Name +  ' -- COLOR: ' + Color
from Production.Product
where Color is not Null



select Name, Color
from Production.Product
where color in ('Black', 'Silver')



select ProductID, Name
from Production.Product
where ProductID BETWEEN 400 and 500



select ProductID, Name
from Production.Product
where color in ('Black', 'Blue')



select *
from Production.Product
where Name like 'S%'



select Name, ListPrice
from Production.Product
where Name like 'S%'
order by Name

select Name, ListPrice
from Production.Product
where Name like '[AS]%'
order by Name



select *
from Production.Product
where Name like 'SPO[^K]%'
order by Name



select distinct Color
from Production.Product
order by  Color desc



select distinct ProductSubcategoryID,  Color
from Production.Product
where Color is not null And ProductSubcategoryID is not null