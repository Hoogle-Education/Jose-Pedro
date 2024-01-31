namespace PropertiesAndAutoProperties.Models;

public class Account
{
  public double Saldo { get; private set; }

  public void Depositar(double quantia) {
    Saldo += quantia;
  }

  public void Sacar(double quantia) {
    if(Saldo >= quantia) {
        Saldo -= quantia;
    }
  }

  public void Transferir(Account reciept, double quantia) {
    if(Saldo >= quantia) {
      this.Sacar(quantia);
      reciept.Depositar(quantia);
    }
  }
}

// SOLID