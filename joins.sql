--JOIN 3 TABLE
SELECT CompanyName ,ProductName
FROM Supplier S
JOIN Product P On  S.Id = P.SupplierId
JOIN OrderItem I ON P.Id = I.ProductId


--INNER JOIN
SELECT CompanyName , ProductName
FROM Supplier S
INNER JOIN Product P
ON S.Id = P.SupplierId


--LEFT JOIN - WILL GIVE MATCHING/NON-MATCHING ROW FROM LEFT AND RIGHT MATCHING ROW 
SELECT ProductName, SUM(I.UnitPrice) AS Total
FROM Product P 
LEFT JOIN OrderItem I ON P.Id = I.ProductId
GROUP BY ProductName
Order By Sum(I.UnitPrice)

--RIGHT JOIN  WILL GIVE MATCHING/NON-MATCHING ROW FROM RIGHT AND LEFT MATCHING ROW 
SELECT ProductName
  FROM OrderItem I 
 RIGHT JOIN Product P ON P.Id = I.ProductId
 WHERE I.Id IS NULL


--SELECT column-names
--  FROM table-name1 
-- RIGHT/left/full JOIN table-name2 
--ON 
--column-name1 = column-name2
-- WHERE condition


--Full Join --KEYWORDS USES []
SELECT C.FirstName, C.LastName, O.OrderDate
  FROM Customer C
  JOIN [Order] O ON C.Id = O.CustomerId


  --SELF JOIN SAME TABLE JOIN
  SELECT A.CompanyName AS Company1 , B.CompanyName AS Company2, A.Country
  FROM Supplier A
  JOIN Supplier B ON A.Id <> B.Id
  And A.Country = B.Country
  
--Update Join
--UPDATE table-name1
--   SET column-name1 = value1, 
--       column-name2 = value2, ...
--  FROM table-name1 
--  JOIN table-name2 ON column-name3 = column-name4
-- WHERE condition

UPDATE P
   SET P.UnitPrice = P.UnitPrice * 1.1
  FROM Product P
  JOIN OrderItem I ON P.Id = I.ProductId
 SET NOCOUNT ON --WILL NOT DISPLAY AFFECTED ROW

 --CROSS JOIN
 SELECT CompanyName , ProductName
 FROM Supplier 
 CROSS JOIN Product