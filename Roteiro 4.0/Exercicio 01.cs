using System;

// ===== CLASSE BASE (mãe) =====
public class Veiculo
{
    public string marca;
    public string modelo;
    public int numero_de_rodas;

    public void ExibirDados()
    {
        Console.WriteLine($"A marca do veículo é {marca}, o modelo é: {modelo}, e o número de rodas é: {numero_de_rodas}");
    }
}

// ===== CLASSE DERIVADA (filha) =====
public class Carro : Veiculo           // ": Veiculo" → herda tudo
{
    public int numero_de_portas;       // só o carro tem
}

// ===== CLASSE DERIVADA (filha) =====
public class Moto : Veiculo            // ": Veiculo" → herda tudo
{
    public bool possui_bagageiro;      // só a moto tem
}

public class Program
{
    public static void Main()
    {
        // ----- CARRO -----
        Carro c = new Carro();
        c.marca = "Toyota";            // herdado
        c.modelo = "Corolla";          // herdado
        c.numero_de_rodas = 4;         // herdado
        c.numero_de_portas = 4;        // do carro

        c.ExibirDados();               // método herdado
        Console.WriteLine($"Número de portas: {c.numero_de_portas}");

        // ----- MOTO -----
        Moto m = new Moto();
        m.marca = "Honda";             // herdado
        m.modelo = "CG 160";           // herdado
        m.numero_de_rodas = 2;         // herdado
        m.possui_bagageiro = true;     // da moto

        m.ExibirDados();               // método herdado
        Console.WriteLine($"Possui bagageiro: {m.possui_bagageiro}");
    }
}