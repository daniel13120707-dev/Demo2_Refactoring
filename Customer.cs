public class Customer
{
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    
    public Address HomeAddress { get; set; } 
    public Address WorkAddress { get; set; }

    public bool Validate()
    {
        bool isHomeAddressValid = HomeAddress != null && HomeAddress.Validate();
        bool isWorkAddressValid = WorkAddress != null && WorkAddress.Validate();
        
        return !string.IsNullOrWhiteSpace(Name) && isHomeAddressValid && isWorkAddressValid;
    }
} 
