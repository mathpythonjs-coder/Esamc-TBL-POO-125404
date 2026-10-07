using System;
using System.Security.Cryptography.X509Certificates;

// CLASSE
public class ContaBancaria
{
    // ATRIBUTOS
    public string titular;
    public int numeroConta;
    public double saldo;

    // MÉTODO DEPOSITAR - recebe o valor por PARÂMETRO e SOMA no saldo
    public void Depositar(double valor)
    {
        if (valor <= 0)                     // não deixa depositar zero ou negativo
        {
            Console.WriteLine("Valor de depósito inválido.");
        }
        else
        {
            saldo += valor;                 // saldo = saldo + valor
            Console.WriteLine($"{titular} depositou R$ {valor:F2}");
        }
    }

    // MÉTODO SACAR - recebe o valor por PARÂMETRO e TIRA do saldo (se tiver)
    public void Sacar(double valor)
    {
        if (valor > saldo)                  // se quer sacar mais do que tem
        {
            Console.WriteLine($"{titular}: saldo insuficiente para sacar R$ {valor:F2}");
        }
        else
        {
            saldo -= valor;                 // saldo = saldo - valor
            Console.WriteLine($"{titular} sacou R$ {valor:F2}");
        }
    }

    // MÉTODO EXIBIR SALDO - só mostra
    public void ExibirSaldo()
    {
        Console.WriteLine($"Conta {numeroConta} | Titular: {titular} | Saldo: R$ {saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria c1 = new ContaBancaria();
        c1.titular = "Matheus";
        c1.numeroConta = 123;
        c1.saldo = 5;
        c1.Depositar(0);
    }
}