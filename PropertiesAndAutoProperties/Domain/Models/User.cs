namespace PropertiesAndAutoProperties.Domain.Models;

public class User
{
   public string Email { get; set; }
   public string Password { get; set; }
   // tem um
   public Address Address { get; set; } 
   // tem varios
   public List<Post> Posts { get; set; } = new List<Post>();

   public override string ToString()
   {
      string aux = $"Email: {Email}\n" 
      + $"Password: {Password}\n" 
      + $"Address: {Address}\n" 
      + $"Posts:\n";

      foreach (Post post in Posts)
      {
         aux += $"\t{post}\n";
      }

      return aux;
   }
}

