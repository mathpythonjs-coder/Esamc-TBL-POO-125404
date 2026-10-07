using System.Diagnostics.Contracts;

public class Retangulo
{
    public double Largura{get; set;}
    public double Alturar{get; set;}

    public double Area
    {
        get {return Largura * Altura;}
    }

    public class Program
    {
        public static void Main()
        {
            Retangulo r = new Retangulo();
            r.Largura = 10;
            r.Alturar = 5;

            Console.WriteLine(r.Area);
        }
    }
}