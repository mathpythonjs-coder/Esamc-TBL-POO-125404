// Questão 1 – Cópia de Tipos de Valor

using System;

class Program
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = a;

        b = 20;

        Console.WriteLine($"a = {a}");
        Console.WriteLine($"b = {b}");
    }
}
