namespace AvaliacaoConhecimentoPrevio;

class Program
{
    static void Main(string[] args)
    {
        List<int> inteiros = new List<int>();
        
        Console.WriteLine("Digite 10 números inteiros:");

        for (int i = 0; i < 10; i++)
        {
            int valor = Convert.ToInt32(Console.ReadLine());
            inteiros.Add(valor);
        }

        var pares = inteiros.Where(n => n % 2 == 0).ToList();
        var impares = inteiros.Where(n => n % 2 != 0).ToList();

        int somaPares = pares.Sum();
        double mediaImpares = impares.Count > 0 ?  impares.Sum() : 0;
        
        Console.WriteLine($"\nSoma dos números pares: {somaPares}");
        Console.WriteLine($"Média dos números ímpares: {mediaImpares:F2}");
    }
}