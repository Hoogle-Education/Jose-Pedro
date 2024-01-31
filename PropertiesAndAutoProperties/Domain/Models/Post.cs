using PropertiesAndAutoProperties.Domain.Enums;

namespace PropertiesAndAutoProperties.Domain.Models;

public class Post
{
   public string Content { get; set; }
   public int Likes { get; set; }
   public Visibility Visibility { get; set; }

   public override string ToString()
   {
      return $"Content: {Content}, Likes: {Likes}";
   }
}
