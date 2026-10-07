using System;

// ===== INTERFACES (contratos) =====
public interface IVoar
{
    void Voar();                      // quem assinar, tem que saber voar
}

public interface INadar
{
    void Nadar();                     // quem assinar, tem que saber nadar
}

// ===== PATO: voa E nada → 2 interfaces separadas por vírgula =====
public class Pato : IVoar, INadar
{
    public void Voar()
    {
        Console.WriteLine("O pato está voando");
    }

    public void Nadar()
    {
        Console.WriteLine("O pato está nadando");
    }
}

// ===== ÁGUIA: só voa → só IVoar =====
public class Aguia : IVoar
{
    public void Voar()
    {
        Console.WriteLine("A águia está voando");
    }
}

// ===== PEIXE: só nada → só INadar =====
public class Peixe : INadar
{
    public void Nadar()
    {
        Console.WriteLine("O peixe está nadando");
    }
}

public class Program
{
    public static void Main()
    {
        // 1 e 2. Pato voa e nada
        Pato pato = new Pato();
        pato.Voar();
        pato.Nadar();

        // 3 e 4. Águia voa
        Aguia aguia = new Aguia();
        aguia.Voar();

        // 5 e 6. Peixe nada
        Peixe peixe = new Peixe();
        peixe.Nadar();
    }
}