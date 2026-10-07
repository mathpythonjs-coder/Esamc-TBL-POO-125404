public class Produto
{
    public string nome;
    public double preco;
    public int quantidade;


    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {nome}, Quantidade: {quantidade} e preço: {preco}");
    }

    public double CalcularValorTotal() // O CalcularValorTotal() é diferente: o exercício diz "retorna preco * quantidade". Ou seja, ele faz a conta e devolve o resultado pra quem chamou.
    {
        return preco * quantidade;
        
    }

}

public class Program
{
    public static void Main()
    {
        Produto p1 = new Produto();
        p1.nome = "Salsicha";
        p1.quantidade = 5;
        p1.preco = 13;
        p1.ExibirDados();
        Console.WriteLine($"Valor Total: R$ {p1.CalcularValorTotal()}");

        Produto p2 = new Produto();
        p2.nome = "Feijão";
        p2.quantidade = 5;
        p2.preco = 14;
        p2.ExibirDados();
        Console.WriteLine($"Valor Total: R$ {p2.CalcularValorTotal()}");

        Produto p3 = new Produto();
        p3.nome = "Arroz";
        p3.quantidade = 7;
        p3.preco = 15;
        p3.ExibirDados();
        Console.WriteLine($"Valor Total: R$ {p3.CalcularValorTotal()}");
    }
}