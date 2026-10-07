using System.Diagnostics.Contracts;

public class carro
{
    private string modelo;
    private int velocidadeATUAL;


    public carro(string modeloCarro)
    {
        modelo = modeloCarro;
        velocidadeATUAL = 0;
    }

    public void Acelerar(int valor)
    {
        if(valor <= 0)
        {
            Console.WriteLine("Valor inválido!");
        }

        else
        {
            velocidadeATUAL += valor;
            Console.WriteLine("O carro: {modelo}, acelerou: {valor}");
        }

        
    }

   public void Frear(int valor)
    {
        if(valor > velocidadeATUAL)
        {
            Console.WriteLine($"{modelo} Parou completamente");
        }

        else
        {
            velocidadeATUAL -= valor;
            Console.WriteLine($"O Modelo: {modelo}, freou {valor} km/h");
        }
    }

    public void ExbibirVelocidade()
    {
        Console.WriteLine($"Velocidade atual do {modelo}: {velocidadeAtual} km/h");

    }


}

public class Program
{
    public static void Main()
    {
        carro c = new carro("Fiat UNO");
        c.Acelerar(120);
        c.ExbibirVelocidade();
    }
}