namespace AvaliacaoConhecimentoPrevio;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Informe seu nome completo:");
        string nome = Console.ReadLine();
        
        Console.WriteLine($"\n{nome.ToUpper()}");
        Console.WriteLine(nome.Length);
        Console.WriteLine(nome.Substring(0, nome.IndexOf(' ')));
    }
}