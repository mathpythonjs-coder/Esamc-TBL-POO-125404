using System.Security.Cryptography.X509Certificates;

public class Fantasma
{
    public string habilidade;
    public string nick;
    public string cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"O nick do fantasma é: {nick}, A Habilidade é: {habilidade} e cor: {cor}");
    }

    public void mover(string direcao)
    {
        Console.WriteLine($"O {nick} se moveu para {direcao}");
    } // parametro.

}


public class Program
{
    public static void Main()
    {
        Fantasma f1 = new Fantasma();
        f1.nick = "Fantasma Fofo";
        f1.habilidade = "Fofura";
        f1.cor = "Rosa";

        f1.GerarFantasma();
        f1.mover("cima");

    }
}