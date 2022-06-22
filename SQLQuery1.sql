--1.
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product

--2.
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE ListPrice != 0

--3.
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE Color IS NOT NULL

--4.
SELECT ProductID,Name,Color,ListPrice
FROM Production.Product
WHERE Color IS NOT NULL
AND ListPrice > 0

--5.
SELECT Name,Color,Name +' '+ Color AS [Name&Color]
FROM Production.Product
WHERE Color IS NOT NULL

--6.
SELECT TOP 6 'NAME: '+ Name +' -- COLOR: '+ Color AS [Name&Color]
FROM Production.Product
WHERE Color IS NOT NULL

--7.
SELECT ProductID,Name
FROM Production.Product
WHERE ProductID BETWEEN 400 AND 500

--8.
SELECT ProductID,Name,Color
FROM Production.Product
WHERE Color IN ('Black','Blue')

--9.
SELECT Name
FROM Production.Product
WHERE Name LIKE 'S%'

--10.
SELECT TOP 5 Name,ListPrice
FROM Production.Product
WHERE Name LIKE '[A,S]%'
ORDER BY Name

--11.
SELECT ProductID, Name
FROM Production.Product
WHERE Name LIKE 'SPO[^K]%'
ORDER BY Name

--12.
SELECT DISTINCT ISNULL(ProductSubcategoryID,0) AS ProductSubcategory,ISNULL(Color,'NoColor') AS Color
FROM Production.Product

