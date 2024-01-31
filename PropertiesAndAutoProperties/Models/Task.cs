namespace PropertiesAndAutoProperties.Models;

public class TodoTask
{
  // name
  // duration
  public int durationInMinutes;

  // checkbox - isCompleted - with autoproperty
  public bool IsCompleted { get; private set; }

  // property with name
  private string _name;
  public string Name {
    get { return _name; }
    set {
      if(value != null && value != string.Empty) {
        _name = value;
      }
    }
  }

  // -----------------------------------
  // first version - getters e setters manuais
  // public void SetName(string name) {
  //   if(name != null && name != string.Empty) {
  //     _name = name;
  //   }
  // }

  // public string GetName() {
  //   return name;
  // }
  // -----------------------------------

  
}
