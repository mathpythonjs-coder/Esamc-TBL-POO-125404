using System;

public class ContaBancaria
{
    // PROPRIEDADES com private set: todos LEEM, só a classe ALTERA
    public string Titular { get; private set; }
    public decimal Saldo { get; private set; }

    // CONSTRUTOR: titular definido na criação, saldo começa em 0
    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    // MÉTODO: só aceita valor maior que 0
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
        else
        {
            Console.WriteLine("Depósito inválido.");
        }
    }

    // MÉTODO: não deixa o saldo ficar negativo
    public void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)   // && = "e"
        {
            Saldo -= valor;
        }
        else
        {
            Console.WriteLine("Saque inválido ou saldo insuficiente.");
        }
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos");

        conta.Depositar(1000);
        conta.Sacar(250);

        Console.WriteLine(conta.Saldo);   // 750

        // conta.Saldo = -5000;           // ❌ ERRO: private set
    }
}