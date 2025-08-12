namespace AvaliacaoConhecimentoPrevio;

public class Funcionario
{
    public string Nome { get; set; }
    protected double Salario { get; set; }

    public Funcionario(string nome, double Salario)
    {
        Nome = nome;
        this.Salario = Salario;
    }

    public virtual double CalcularBonus()
    {
        return Salario * 0.10;
    }
}

public class Gerente : Funcionario
{
    public Gerente(string nome, double Salario) : base(nome, Salario)
    {}

    public override double CalcularBonus()
    {
        return Salario * 0.20;
    }
}

class Program {
    static void Main(string[] args)
    {
        Funcionario f = new Funcionario("João", 2000);
        Gerente g = new Gerente("Maria", 2000);

        Console.WriteLine($"Bônus do Funcionário: {f.CalcularBonus()}");
        Console.WriteLine($"Bônus do Gerente: {g.CalcularBonus()}");
    }
}