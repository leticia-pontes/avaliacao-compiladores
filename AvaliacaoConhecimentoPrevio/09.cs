namespace AvaliacaoConhecimentoPrevio;

class Program {
    static void Main(string[] args)
    {
        Console.WriteLine("Digite dois valores inteiros:");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        try
        {
            var divisao = n1 / n2;
            Console.WriteLine($"Divisão: {divisao}");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine($"ERRO: Não é possível realizar divisão por zero.");
        }
    } 
}