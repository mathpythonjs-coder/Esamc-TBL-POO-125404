using System;

public class Aluno
{
    // ===== NOME (não pode ser vazio) =====
    private string nome;                         // caixa

    public string Nome                           // porta
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            nome = value;
        }
    }

    // ===== NOTA 1 (entre 0 e 10) =====
    private double nota1;

    public double Nota1
    {
        get { return nota1; }
        set
        {
            if (value < 0 || value > 10)         // || = "ou"
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }
            nota1 = value;
        }
    }

    // ===== NOTA 2 (entre 0 e 10) =====
    private double nota2;

    public double Nota2
    {
        get { return nota2; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("A nota deve estar entre 0 e 10.");
            }
            nota2 = value;
        }
    }

    // ===== MÉDIA (calculada, só get) =====
    public double Media
    {
        get { return (Nota1 + Nota2) / 2; }
    }
}

public class Program
{
    public static void Main()
    {
        Aluno aluno = new Aluno();

        try
        {
            aluno.Nome = "Maria";
            aluno.Nota1 = 8;
            aluno.Nota2 = 6;
            Console.WriteLine($"Média: {aluno.Media}");   // 7

            aluno.Nota2 = 10;
            Console.WriteLine($"Nova média: {aluno.Media}");   // 9

            aluno.Nota1 = 15;                              // inválida
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        // aluno.Media = 10;   // ❌ ERRO: Media não tem set
    }
}