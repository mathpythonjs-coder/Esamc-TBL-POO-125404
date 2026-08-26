// Questão 4 – Conversão Segura com TryParse

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número: ");
        string entrada = Console.ReadLine();

        bool sucesso = int.TryParse(entrada, out int numero);

        if (sucesso)
        {
            Console.WriteLine($"Número digitado: {numero}");
        }
        else
        {
            Console.WriteLine("Entrada inválida. Digite um número válido.");
        }
    }
}
