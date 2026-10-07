using System.Security.Cryptography; // ESTUDOOOSSSS!!!

public class Carro // classe = molde
{
    public string marca; // atributos
    public string modelo;
    public int ano;
    
    // Metodos
    public void ExibirDados()
    {
        Console.WriteLine($"O carro é da marca: {marca}, Modelo: {modelo} e do Ano: {ano}");
    }

    public void Buzinar()
    {
        Console.WriteLine($"O {modelo } Buzinou: BIIIIIIIIIIIIIIIIIIIIIIIIIIIII");
    }
}


public class Program
{
    public static void Main()
    {
        Carro c1 = new Carro();
        c1.marca = "VolksWagen";
        c1.modelo = "Gol G3";
        c1.ano = 1995;

        c1.ExibirDados();
        c1.Buzinar();


        Carro c2 = new Carro();
        c1.marca = "VolsWagen";
        c1.modelo = "GOL G2";
        c1.ano = 1990;

        c1.ExibirDados();
        c1.Buzinar();

        Carro c3 = new Carro();

        c1.marca = "TOP";
        c1.ExibirDados();
    }
}