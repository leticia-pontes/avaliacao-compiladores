namespace AvaliacaoConhecimentoPrevio;

class Program {
    static void Main(string[] args)
    {
        int[] numeros = new int[50];
        Random rnd = new Random();

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = rnd.Next(0, 101);
            Console.Write($"{numeros[i]} ");
        }

        int maioresQueSetentaECinco = 0;
        
        foreach (var numero in numeros)
        {
            if (numero > 75)
            {
                maioresQueSetentaECinco++;
            }    
        }
        
        Console.WriteLine($"\n{maioresQueSetentaECinco} números são maiores que 75");
    }
}