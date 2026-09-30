Gerente gerente = new Gerente();
gerente.Nome = "Ana";

Programador programador = new Programador();
programador.Nome = "Carlos";

Console.WriteLine($"{gerente.Nome}: R${gerente.CalcularSalario()}");
Console.WriteLine($"{programador.Nome}: R${programador.CalcularSalario()}");

List<Funcionario> funcionarios = new List<Funcionario>();
funcionarios.Add(gerente);
funcionarios.Add(programador);

foreach (Funcionario funcionario in funcionarios)
{
    Console.WriteLine($"{funcionario.Nome}: R${funcionario.CalcularSalario()}");
}

abstract class Funcionario
{
    public string Nome;

    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 8000;
    }
}

class Programador : Funcionario
{
    public override decimal CalcularSalario()
    {
        return 6000;
    }
}
