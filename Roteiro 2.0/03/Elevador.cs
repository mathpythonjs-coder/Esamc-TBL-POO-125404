public class Elevador
{
    private int andarAtual;
    private int totalAndares;


    public Elevador(int totaldeandares) // usuario vai digitar o total de andares
    {
        andarAtual = 0;
        totalAndares = totaldeandares;
    }
    
    public void Subir()
    {
        if(andarAtual < totalAndares)
        {
            andarAtual++;
            Console.WriteLine($"O andar subiu um andar: está no andar > {andarAtual}");
        }

        else
        {
            Console.WriteLine("Você está no ultimo andar.");
        }

    }

    public void Descer()
    {
        if(andarAtual > 0)
        {
            andarAtual--;
            Console.WriteLine($"O andar desceu um andar: está no andar > {andarAtual}");
        }

        else
        {
            Console.WriteLine("Já está no térreo!");
        }
    }

       public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}

public class Program
{
    public static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Descer();
    }
}

