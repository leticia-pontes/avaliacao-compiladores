namespace AvaliacaoConhecimentoPrevio;

class Program {
    static void Main(string[] args)
    {
        int[] inteiros = { 10, 25, 30, 45, 60, 75, 90 };
        
        var maioresQueCinquenta = from inteiro in inteiros
                                  where inteiro > 50
                                  select inteiro;
        
        var media = maioresQueCinquenta.Average();
        
        Console.WriteLine("Números maiores que 50:");
        foreach (var num in maioresQueCinquenta)
        {
            Console.Write($"{num} ");
        }
        
        Console.WriteLine($"\nMédia dos números maiores que 50: {media}");
    }
}