public class Pessoa { // Classe - molde
    // Atributos - oque a pessoa tem.
    public String nome;
    public int idade;
    public String cargo;

    // Metodo

    public void Apresentar() // void não devolve nada ele apenas executa.
    {
        Console.WriteLine($"Olá, meu nome é {nome} e tenho {idade} anos.");
    }

    public void ExibirSalario()
    {
        switch (cargo)
        {
            case "Gerente": // OPTION
                Console.WriteLine($"{nome}, {cargo} ganha R$ 10.000,00");
                break; // ACBAA.
            
            case "Desenvolvedor":
                Console.WriteLine($"{nome}, {cargo} ganha 5000,00");
                break;
            
            case "Estagiário":
                Console.WriteLine($"{nome}, {cargo} ganha 100,00");
                break;

            default:
                Console.WriteLine($"{nome}: Cargo não cadastrado.");
                break;

        }
    }
}


// Classe principal aonde o programa vai rodar.

public class Program{
    // Metodo main ponto de partida
    public static void Main(){
        // Objeto
        Pessoa p1 = new Pessoa(); // Criamos o OBJETO
        p1.idade = 15;
        p1.nome = "Matheus";
        p1.cargo = "Gerente";

        // chamando o metodo atraves do Objeto.
        p1.Apresentar();
        p1.ExibirSalario();

    
        Pessoa p2 = new Pessoa(); // Criamos o OBJETO
        p2.idade = 15;
        p2.nome = "Ana";
        p2.cargo = "Desenvolvedor";

        // chamando o metodo atraves do Objeto.
        p2.Apresentar();
        p2.ExibirSalario();


        Pessoa p3 = new Pessoa(); // Criamos o OBJETO
        p3.idade = 15;
        p3.nome = "Italo";
        p3.cargo = "Estagiario";

        // chamando o metodo atraves do Objeto.
        p3.Apresentar();
        p3.ExibirSalario();
    }
}