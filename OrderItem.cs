public class OrderItem
{
    public Product Product { get; set; }
    public int Quantity { get; set; }
    public decimal PurchasePrice { get; set; }
    public bool Validate() { return Product != null && Quantity > 0; }
} 
