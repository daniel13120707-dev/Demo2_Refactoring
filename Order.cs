using System;

public class Order
{
    public Customer Customer { get; set; }
    public DateTime OrderDate { get; set; }
    public Address ShippingAddress { get; set; } 

    public bool Validate()
    {
        return Customer != null && ShippingAddress != null && ShippingAddress.Validate();
    }
} 
