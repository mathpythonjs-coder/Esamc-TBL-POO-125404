List<Pagamento> pagamentos = new List<Pagamento>();

pagamentos.Add(new CartaoCredito());
pagamentos.Add(new BoletoBancario());
pagamentos.Add(new Pix());

foreach (Pagamento pagamento in pagamentos)
{
    pagamento.ProcessarPagamento();
}

// A lista pode ser do tipo Pagamento porque CartaoCredito, BoletoBancario e Pix
// herdam de Pagamento, ou seja, cada uma "é um" Pagamento. A lista guarda o tipo
// comum, mas cada objeto executa sua própria versão de ProcessarPagamento().

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Cartão de Crédito");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Boleto Bancário");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento via Pix");
    }
}

