using System;

public class Produto
{
    // CASO 3: definido no construtor, não muda de fora
    public string Nome { get; private set; }
    public string Codigo { get; private set; }

    // CASO 2: tem regra (não pode negativo)
    private decimal preco;                      // caixa
    public decimal Preco                        // porta
    {
        get { return preco; }
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }
            preco = value;
        }
    }

    // CASO 3: só muda pelos métodos
    public int QuantidadeEstoque { get; private set; }

    // CASO 1: calculada (true se tiver 5 ou menos)
    public bool EstoqueBaixo
    {
        get { return QuantidadeEstoque <= 5; }
    }

    // CONSTRUTOR (mesmo nome da classe)
    public Produto(string nome, string codigo, decimal preco)
    {
        if (string.IsNullOrWhiteSpace(nome))
        {
            throw new ArgumentException("O nome é obrigatório.");
        }
        if (string.IsNullOrWhiteSpace(codigo))
        {
            throw new ArgumentException("O código é obrigatório.");
        }

        Nome = nome;
        Codigo = codigo;
        Preco = preco;              // passa pelo set e valida
        QuantidadeEstoque = 0;
    }

    // MÉTODO: adiciona estoque
    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }
        QuantidadeEstoque += quantidade;
    }

    // MÉTODO: remove estoque (não deixa tirar mais do que tem)
    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0 || quantidade > QuantidadeEstoque)
        {
            throw new ArgumentException("Quantidade inválida ou estoque insuficiente.");
        }
        QuantidadeEstoque -= quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        try
        {
            Produto produto = new Produto("Teclado", "TEC001", 150);

            produto.AdicionarEstoque(20);
            Console.WriteLine(produto.QuantidadeEstoque);   // 20

            produto.RemoverEstoque(10);
            Console.WriteLine(produto.QuantidadeEstoque);   // 10

            Console.WriteLine(produto.EstoqueBaixo);        // False

            // produto.QuantidadeEstoque = 500;             // ❌ ERRO: private set
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Erro: " + ex.Message);
        }
    }
}