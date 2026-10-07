using System;

public class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nomeProduto, decimal precoProduto) // construtor
    {
        nome = nomeProduto;

        if (precoProduto < 0)
        {
            Console.WriteLine($"O número não pode ser menor que 0.");
        }

        else
        {
            preco = precoProduto;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {nome}, Preço: {preco}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine("O número não pode ser MENOR que 0");
        }

        else
        {
            preco = novoPreco;
            Console.WriteLine($"O preço foi alterado com SUCESSO! R$ {preco}");
        }
    }
}


public class Program
{
    public static void Main()
    {
        Produto p = new Produto("Celular", 1500);

        p.ExibirDetalhes();
        p.AlterarPreco(200);
    }
}