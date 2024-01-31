using PropertiesAndAutoProperties.Models;

namespace PropertiesAndAutoProperties;

public class Program
{
  public static void Main(string[] args)
  {
      TodoTask shoppingTask = new TodoTask();

      // shoppingTask.durationInMinutes = -200;
      // shoppingTask.IsCompleted = true;

      // Console.WriteLine(shoppingTask.IsCompleted);
      
      Invoice invoice = new Invoice();

      invoice.BasePayment = 100.0;
      invoice.Tax = 20.0;
      invoice.Iof = 5.0;

      Console.WriteLine(invoice.TotalPayment);

      // Account conta = new Account();

      // // conta.saldo = 1000000000;

      // conta.Depositar(200);
      // conta.Sacar(200);

      // Console.WriteLine(conta.saldo);
      
  }
}