--1.
CREATE VIEW view_product_order_Cai 
AS
SELECT p.ProductID,p.ProductName, SUM(d.Quantity)TotalQuantities
FROM Products p JOIN [Order Details] d ON p.ProductID = d.ProductID
GROUP BY p.ProductID,p.ProductName
--Testing purpose
SELECT * 
FROM view_product_order_Cai

--2.
CREATE PROC sp_product_order_quantity_Cai
@productID int,
@totalquan int out
AS
BEGIN
SELECT @totalquan = TotalQuantities FROM view_product_order_Cai WHERE ProductID = @productID
END
--Testing
BEGIN
DECLARE @quan int
EXEC sp_product_order_quantity_Cai 23, @quan out
SELECT @quan
END

--3.
CREATE PROC sp_product_order_city_Cai
@productID int
AS
BEGIN
SELECT TOP 5 c.City, SUM(d.Quantity) TotalQuantity
FROM [Order Details] d
JOIN Orders o ON d.OrderID=o.OrderID
JOIN Customers c ON o.CustomerID = c.CustomerID
WHERE d.ProductID = @productID
GROUP BY c.City
ORDER BY SUM(d.Quantity) DESC
END
--Testing
EXEC sp_product_order_city_Cai 23

--4.
CREATE TABLE people_Cai
(
id int,
[Name] varchar(30),
City int
)
CREATE TABLE city_Cai
(
id int,
City varchar(30)
)

INSERT INTO people_Cai
VALUES
(1,'Aaron Rodgers',2),
(2,'Russell Wilson',1),
(3,'Jody Nelson',2)

INSERT INTO city_Cai
VALUES
(1,'Seattle'),
(2,'Greenbay')

DELETE FROM city_Cai WHERE City = 'Seattle'
INSERT INTO city_Cai
VALUES
(1,'Madison')

CREATE VIEW Packers_Cai
AS
SELECT [Name] FROM people_Cai WHERE City = 2

SELECT * FROM Packers_Cai

--5.
CREATE PROC sp_birthday_employees_Cai
AS
BEGIN

CREATE TABLE birthday_employees_Cai
(
[Name] varchar(30),
BirthDate date
)

INSERT INTO birthday_employees_Cai ([Name],BirthDate)
SELECT FirstName + ' ' + LastName, BirthDate
FROM Employees
WHERE Month(BirthDate) = 2

SELECT * FROM birthday_employees_Cai

DROP TABLE birthday_employees_Cai

END

EXEC sp_birthday_employees_Cai

--6.
--I think first of all for smaller dataset we can check by human eye
--Or we can use where clause to check if any data in the tables are not match
--Maybe we can also use UNION, since the union will drop duplicate rows, if the number of the rows are the same after union mean every row is duplicated.