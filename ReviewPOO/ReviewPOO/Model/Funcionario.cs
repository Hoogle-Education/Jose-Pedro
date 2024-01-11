namespace ReviewPOO.Model;

public class Funcionario
{
    // tem - atributos
    private int _id;
    private string _nome;
    private double _salario;
    private double _imposto;
    private string _cargo;

    // (metodo) construtor
    public Funcionario() {
    }

    public Funcionario(int id, string nome, double salario)
    {
        _id = id;
        _nome = nome;
        _salario = salario;
        _imposto = salario * 0.1;
    }

    public Funcionario(int id, string nome, double salario, string cargo)
        : this(id, nome, salario)
    {
        _cargo = cargo;
    }

    public string Nome {
        get {  return _nome; }
        set {
            if (value != null)
            {
                _nome = value;
            }
        }
    }

    public double SalarioLiquido
    {
        get { return _salario - _imposto;  }
    }

    // faz - metodos
    public void ReceberAumento(double aumento)
    {
        _salario += aumento;
    }

    public void ReceberAumento(double aumento, double taxaPerformance)
    {
        _salario += aumento;
        double porcentagemAumento = 1 + taxaPerformance;
        _salario *= porcentagemAumento;
    }
}
