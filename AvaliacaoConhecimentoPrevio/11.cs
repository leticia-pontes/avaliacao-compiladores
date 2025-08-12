namespace AvaliacaoConhecimentoPrevio;

class Program {
    static string VerificarAprovacao(double n1, double n2)
    {
        double media = (n1 + n2) / 2;

        if (media >= 6) return "Aprovado";
        if (media >= 4) return "Recuperação";
        return "Reprovado";
    }
    
    static void Main(string[] args)
    {
        double n1 = 4;
        double n2 = 6;
        
        string aprovacao = VerificarAprovacao(n1, n2);
        Console.WriteLine(aprovacao);
    }    
}