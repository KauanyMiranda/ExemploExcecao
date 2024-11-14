using static System.Convert;
using static System.Console;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Excecao c = new Excecao();
            Write("Digite um valor: ");
            double saldo = ToDouble(ReadLine());
            c.SetSaldo(saldo);
        }
        catch (Exception Ex)
        {
            WriteLine($"Valor informado inválido {Ex.Message}");
        }
    }
}
