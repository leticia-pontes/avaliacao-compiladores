namespace AvaliacaoConhecimentoPrevio;

public class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        this.Nome = nome;
    }

    public virtual void EmitirSom()
    {
        Console.WriteLine("O animal emite som.");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome)
    {}

    public override void EmitirSom()
    {
        Console.WriteLine("O cachorro late.");    
    }
}

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal("Animal");
        animal.EmitirSom();
        
        Cachorro cachorro = new Cachorro("Tótó");
        cachorro.EmitirSom();
    }
}