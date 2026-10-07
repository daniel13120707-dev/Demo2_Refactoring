using System;

public class ProductRepository
{
    public Product Retrieve(int productId)
    {
        Console.WriteLine($"Загрузка продукта {productId}...");
        return new Product { ProductName = "Ноутбук", CurrentPrice = 50000 };
    }

    public void Save(Product product)
    {
        if (product.Validate())
        {
            Console.WriteLine($"Сохранение продукта {product.ProductName}...");
        }
    }
} 
