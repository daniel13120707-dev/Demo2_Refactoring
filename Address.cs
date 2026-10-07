using System;

public class Address
{
    public string StreetLine1 { get; set; }
    public string StreetLine2 { get; set; }
    public string City { get; set; }
    public string StateProv { get; set; }
    public string PostalCode { get; set; }
    public string Country { get; set; }

    public bool Validate()
    {
        return !string.IsNullOrWhiteSpace(StreetLine1) && 
               !string.IsNullOrWhiteSpace(City) && 
               !string.IsNullOrWhiteSpace(PostalCode);
    }
}
