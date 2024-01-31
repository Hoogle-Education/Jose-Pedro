namespace PropertiesAndAutoProperties.Domain.Models;

public class TodoTask
{
  public string Descricao { get; set; }
  public int DurationInMinutes { get; set; }
  public bool IsCompleted { get; private set; }

}
