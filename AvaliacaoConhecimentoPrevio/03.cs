namespace AvaliacaoConhecimentoPrevio;

public class Produto
{
    public int Id;
    public string Nome;
    public double Preco;

    public Produto(int id, string nome, double preco)
    {
        this.Id = id;
        this.Nome = nome;
        this.Preco = preco;
    }

    public void AplicarDesconto(double percentual)
    {
        if (percentual < 0 || percentual > 100)
        {
            throw new ArgumentException("Percentual deve estar entre 0 e 100.");
        }
        
        Preco -= Preco * (percentual / 100); 
    } 
}

class Program
{
    static void Main(string[] args)
    {
        Produto produto = new Produto(1, "Notebook", 3000);
        
        produto.AplicarDesconto(15);

        Console.WriteLine($"Produto: {produto.Nome}");
        Console.WriteLine($"Preço com desconto: {produto.Preco:C2}");
    }
}