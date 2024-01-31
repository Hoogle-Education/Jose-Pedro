namespace PropertiesAndAutoProperties.Domain.Models;

public class Address
{
   public string Number { get; set; }
   public string Street { get; set; }
   public string City { get; set; }
   public string Country { get; set; }

   public override string ToString()
   {
      return $"Number: {Number}, Street: {Street}, City: {City}, Country: {Country}";
   }
   
}
