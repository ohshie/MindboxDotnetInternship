MSSQL:

SELECT 
    p.ProductName, 
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;


Тут сразу обозначу что для большинства квери просто дергаю гпт, сам sql в основном юзаю через EF. ОЧЕНЬ редко когда пишу их сам (надо учиться)
