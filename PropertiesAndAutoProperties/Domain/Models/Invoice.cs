namespace PropertiesAndAutoProperties.Domain.Models;

public class Invoice
{

  public double BasePayment { get; set; }
  public double Tax { get; set; }
  public double Iof { get; set; }

  public double TotalPayment {
    get { return BasePayment - Tax - Iof; }
  }

}