using System;

public class Pessoa
{
    // Nome: todos LEEM, só a classe ALTERA
    public string Nome { get; private set; }

    // Idade e Email: livres (todos leem e alteram)
    public int Idade { get; set; }
    public string Email { get; set; }

    // CONSTRUTOR: única forma de definir o Nome
    public Pessoa(string nome)
    {
        Nome = nome;   // dentro da classe, o private set permite
    }
}

public class Program
{
    public static void Main()
    {
        // 1. cria a pessoa já com o nome (pelo construtor)
        Pessoa p = new Pessoa("Math");

        // 2. atribui os outros valores
        p.Idade = 20;
        p.Email = "math@email.com";

        // 3. exibe
        Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade} | Email: {p.Email}");

        // 4. altera a idade (pode, o set é público)
        p.Idade = 21;

        // 5. exibe novamente
        Console.WriteLine($"Nome: {p.Nome} | Idade: {p.Idade} | Email: {p.Email}");

        // p.Nome = "Outro";   // ❌ ERRO: o set do Nome é private
    }
}