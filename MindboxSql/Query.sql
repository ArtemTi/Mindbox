SELECT ProductName = Products.Name, CategoryName = Categories.Name
FROM Products 
LEFT JOIN ProductsCategories ON ProductsCategories.ProductId = Products.Id
LEFT JOIN Categories ON ProductsCategories.CategoryId = Categories.Id