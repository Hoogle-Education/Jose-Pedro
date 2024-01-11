using ReviewPOO.Model;

namespace ReviewPOO; 

public class Program
{
    //public static void ApresentarFuncionario(int index, string[] ids, string[] nomes)
    //{
    //    Console.WriteLine(ids[index]);
    //    Console.WriteLine(nomes[index]);
    //}

    //int quantidade = 1000;

    //string[] ids = new string[quantidade];
    //string[] nomes = new string[quantidade];
    //double[] salarios = new double[quantidade];
    //string[] cargos = new string[quantidade];

    //int a = 2, b = 3; // a = 2, b = 3
    //int aux = a; // a = 2, b = 3, aux = 2
    //a = b; // a = 3, b = 3, aux = 2
    //    b = aux; // a = 3, b = 2, aux = 2

    //ApresentarFuncionario(3, ids, nomes);

    public static void Main() // entrypoint
    {
        Funcionario f1 = new Funcionario(1, "Joao da Silva", 2000);
        Funcionario f2 = new Funcionario(2, "Maria da Silva", 5000);

        //f1.nome = "Joao da Silva";
        //f2.nome = "Maria da Silva";
        // f1.salario = -200;

        Funcionario aux = f1;
        f1 = f2;
        f2 = aux;

        Funcionario[] funcionarios = new Funcionario[1000];

        funcionarios[0] = new Funcionario();
        funcionarios[1] = f1;

        f1.Nome = "teste";

        Console.WriteLine( funcionarios.Length );
        Console.WriteLine(f1.SalarioLiquido);

    }
}