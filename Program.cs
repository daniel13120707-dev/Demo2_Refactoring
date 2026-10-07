using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--- Демонстрация Demo_2 ---");

        var customerRepo = new CustomerRepository();

        Customer myCustomer = customerRepo.Retrieve(1);
        
        myCustomer.Name = "Петр";
        myCustomer.HomeAddress = new Address 
        { 
            StreetLine1 = "Ленина", 
            City = "Москва", 
            PostalCode = "101000" 
        };

        customerRepo.Save(myCustomer);

        Console.WriteLine("\n--- Проверка завершена ---");
    }
}