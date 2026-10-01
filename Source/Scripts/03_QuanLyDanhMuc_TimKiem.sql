SELECT * FROM Products 
WHERE CategoryId = 1;

SELECT * FROM Products 
WHERE Name LIKE N'%Phi Thúy%';

SELECT * FROM Products 
WHERE Price >= 2000000 AND Price <= 5000000;

SELECT * FROM Products 
WHERE CategoryId = 1 AND Price < 3000000;