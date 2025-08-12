namespace AvaliacaoConhecimentoPrevio;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    private string _anoPublicacao;
    
    public string AnoPublicacao 
    {
        get { return _anoPublicacao; }
    }

    public Livro(string titulo, string autor, string anoPublicacao)
    {
        Titulo = titulo;
        Autor = autor;
        this._anoPublicacao = anoPublicacao;
    }

    public Livro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        _anoPublicacao = "";
    }
}

class Program 
{
    static void Main(string[] args)
    {
        Livro livro1 = new Livro("1984", "George Orwell", "1949");
        Livro livro2 = new Livro("O Pequeno Príncipe", "Antoine de Saint-Exupéry");

        Console.WriteLine($"Livro 1: {livro1.Titulo}, {livro1.Autor}, Ano: {livro1.AnoPublicacao}");
        Console.WriteLine($"Livro 2: {livro2.Titulo}, {livro2.Autor}, Ano: {livro2.AnoPublicacao}");
    }
}