using System;

public class CustomerRepository
{
    public Customer Retrieve(int customerId)
    {
        Console.WriteLine($"Загрузка клиента с ID {customerId} из базы...");
        return new Customer { Name = "Иван", HomeAddress = new Address { City = "Москва" } };
    }

    public void Save(Customer customer)
    {
        if (customer.Validate())
        {
            Console.WriteLine($"Сохранение клиента {customer.Name} в базу...");
        }
        else
        {
            Console.WriteLine("Ошибка: Клиент не прошел валидацию!");
        }
    }
} 
