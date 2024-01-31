
using PropertiesAndAutoProperties.Domain.Enums;
using PropertiesAndAutoProperties.Domain.Models;

namespace PropertiesAndAutoProperties;

public class Program
{
  public static void Main(string[] args)
  {
      // TodoTask shoppingTask = new TodoTask();

      // shoppingTask.durationInMinutes = -200;
      // shoppingTask.IsCompleted = true;

      // Console.WriteLine(shoppingTask.IsCompleted);
      
      // Invoice invoice = new Invoice();

      // invoice.BasePayment = 100.0;
      // invoice.Tax = 20.0;
      // invoice.Iof = 5.0;

      // Account conta = new Account();

      // // conta.saldo = 1000000000;

      // conta.Depositar(200);
      // conta.Sacar(200);

      // Console.WriteLine(conta.saldo);


      User user = new() {
        Email = "teste@email.com",
        Password = "pass123",
        Address = new() {
          Number = "123",
          Street = "Rua 1",
          City = "São Paulo",
          Country = "Brasil"
        },
        Posts = new List<Post> {
          new() {
            Content = "Conteúdo do post 1",
            Likes = 10,
            Visibility = Visibility.ONLY_ME
          },
          new() {
            Content = "Conteúdo do post 2",
            Likes = 20
          }
        }
      };

      Console.WriteLine(user);
  }
}