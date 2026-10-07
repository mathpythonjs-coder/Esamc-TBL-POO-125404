public class Contabancaria
{
    public decimal Saldo { get; private set;}


    public void Depositar(decimal valor)
    {
        if ( valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Valor inválido! ");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Contabancaria c = new Contabancaria();
        c.Depositar(100);

    }
}