using System;

class Pessoa
{
    public string nome;
}

class Program
{
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.nome = "Matheus";

        Pessoa p2 = p1;

        p2.nome = "Fernandes";

        Console.WriteLine($"p1.nome = {p1.nome}");
        Console.WriteLine($"p1.nome = {p1.nome}");

    }
}