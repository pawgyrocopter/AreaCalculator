SELECT Products.name, Categories.name FROM Products
LEFT JOIN Category ON Products.id = Categories.productId 
ORDER BY Products.name;