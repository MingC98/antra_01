--1.
SELECT c.name Country,p.name Province
FROM Person.CountryRegion c JOIN Person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode

--2.
SELECT c.name Country,p.name Province
FROM Person.CountryRegion c JOIN Person.StateProvince p ON c.CountryRegionCode = p.CountryRegionCode
WHERE c.name IN ('Germany','Canada')

--3.
SELECT p.ProductName,o.OrderDate
FROM Orders o
JOIN [Order Details] d ON o.OrderID = d.OrderID
JOIN Products p ON d.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR,-25,GETDATE())

--4.
SELECT p.ProductName,Count(o.OrderDate) Sales
FROM Orders o
JOIN [Order Details] d ON o.OrderID = d.OrderID
JOIN Products p ON d.ProductID = p.ProductID
WHERE o.OrderDate >= DATEADD(YEAR,-25,GETDATE())
GROUP BY p.ProductName

--5.
SELECT City,Count(CustomerID) numCustomer
FROM Customers
GROUP BY City

--6.
SELECT City,Count(CustomerID) numCustomer
FROM Customers
GROUP BY City
HAVING Count(CustomerID) > 2

--7.
SELECT c.ContactName, Count(d.Quantity) numProducts
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] d ON o.OrderID = d.OrderID
GROUP BY c.ContactName

--8.
SELECT c.CustomerID, Count(d.Quantity) numProducts
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] d ON o.OrderID = d.OrderID
GROUP BY c.CustomerID
HAVING Count(d.Quantity)>100

--9.
SELECT s.CompanyName [Supplier Company Name], sh.CompanyName [Shipping Company Name]
FROM Suppliers s CROSS JOIN Shippers sh

--10.
SELECT p.ProductName,o.OrderDate
FROM Orders o
JOIN [Order Details] d ON o.OrderID = d.OrderID
JOIN Products p ON d.ProductID = p.ProductID
ORDER BY o.OrderDate

--11.
SELECT e.FirstName+' '+e.LastName [Name1], m.FirstName+' '+m.LastName [Name2]
FROM Employees e JOIN Employees m ON e.Title = m.Title
WHERE e.EmployeeID != m.EmployeeID

--12.
SELECT m.FirstName + ' ' + m.LastName AS Manager, COUNT(e.EmployeeID) numEmployees
FROM Employees e INNER JOIN Employees m ON e.ReportsTo = m.EmployeeID
GROUP BY m.FirstName + ' ' + m.LastName
HAVING COUNT(e.EmployeeID) > 2

--13.
SELECT City, CompanyName, ContactName, 'Constomer' [Type]
FROM Customers
UNION ALL
SELECT City, CompanyName, ContactName, 'Supplier' [Type]
FROM Suppliers
ORDER BY City

--14.
SELECT City
FROM Customers
UNION
SELECT City
FROM Employees

--15.
--a
SELECT City
FROM Customers
WHERE City NOT IN (SELECT City FROM Employees)
--b
SELECT c.City
FROM Customers c
LEFT JOIN Employees e ON c.City=e.City
WHERE e.City IS NULL

--16.
SELECT p.ProductName, Count(d.Quantity) Quantity
FROM Products p LEFT JOIN [Order Details] d ON p.ProductID = d.ProductID
GROUP BY p.ProductName

--17.
--a.
SELECT City, Count(CustomerID) numCustomers
FROM Customers
GROUP BY City
HAVING Count(CustomerID)=2
UNION
SELECT City, Count(CustomerID) numCustomers
FROM Customers
GROUP BY City
HAVING Count(CustomerID)>2
--b.
SELECT City, Count(CustomerID) numCustomers
FROM Customers
GROUP BY City
HAVING Count(CustomerID)>=2

--18.
SELECT c.City,Count(p.ProductID)num
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] d ON o.OrderID = d.OrderID
JOIN Products p ON d.ProductID = p.ProductID
JOIN (
SELECT DISTINCT c.City,p.CategoryID
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] d ON o.OrderID = d.OrderID
JOIN Products p ON d.ProductID = p.ProductID
)dd ON c.City = dd.City
GROUP BY c.City
HAVING Count(p.ProductID)>2

--19.
SELECT TOP 5 p.ProductID,SUM(d.Quantity) Quantity, AVG(d.UnitPrice) AveragePrice, RANK() OVER (ORDER BY SUM(d.Quantity)) RNK
FROM Products p
JOIN [Order Details] d ON p.ProductID = d.ProductID
JOIN Orders o ON o.OrderID = d.OrderID
GROUP BY p.ProductID

--20.
SELECT City
FROM (
SELECT d.ShipCity, Count(d.OrderID)
FROM Orders d
GROUP BY d.ShipCity
) s1 JOIN
(
SELECT e.City, d.EmployeeID
FROM Orders d
JOIN Employees e ON e.EmployeeID = d.EmployeeID
) s2 ON s1.ShipCity = s2.City
--21. Update the table using distinct clause