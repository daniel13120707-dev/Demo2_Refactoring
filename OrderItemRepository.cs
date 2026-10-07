using System;

public class OrderItemRepository
{
    public OrderItem Retrieve(int orderItemId)
    {
        Console.WriteLine($"Загрузка позиции заказа {orderItemId}...");
        return new OrderItem();
    }

    public void Save(OrderItem orderItem)
    {
        if (orderItem.Validate())
        {
            Console.WriteLine($"Сохранение позиции заказа...");
        }
    }
} 
