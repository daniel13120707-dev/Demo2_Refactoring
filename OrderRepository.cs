 using System;

public class OrderRepository
{
    public Order Retrieve(int orderId)
    {
        Console.WriteLine($"Загрузка заказа {orderId}...");
        return new Order { OrderDate = DateTime.Now };
    }

    public void Save(Order order)
    {
        if (order.Validate())
        {
            Console.WriteLine($"Сохранение заказа от {order.OrderDate}...");
        }
    }
}