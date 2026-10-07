public class Product
{
    public string ProductName { get; set; }
    public string Description { get; set; }
    public decimal CurrentPrice { get; set; }
    public bool Validate() { return !string.IsNullOrWhiteSpace(ProductName); }
} 
