using System;

public class Produto
{
    // ===== PREÇO =====
    private decimal preco;              // dado escondido

    public decimal Preco
    {
        get { return preco; }           // LER
        set                             // ALTERAR (com regra)
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }
            preco = value;              // só chega aqui se for válido
        }
    }

    // ===== NOME =====
    private string nome;

    public string Nome
    {
        get { return nome; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))   // vazio ou só espaços
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }
            nome = value;
        }
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto = new Produto();

        // ----- Teste do PREÇO -----
        try
        {
            produto.Preco = 100;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = 250;
            Console.WriteLine($"Preço: {produto.Preco}");

            produto.Preco = -50;                         // dá erro aqui
            Console.WriteLine("Essa linha nunca roda");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }

        Console.WriteLine($"Preço final: {produto.Preco}");   // continua 250

        // ----- Teste do NOME -----
        try
        {
            produto.Nome = "Teclado";
            Console.WriteLine($"Nome: {produto.Nome}");

            produto.Nome = "";                           // dá erro aqui
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}