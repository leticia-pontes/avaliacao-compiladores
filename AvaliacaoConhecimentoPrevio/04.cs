namespace AvaliacaoConhecimentoPrevio;

class Program
{
    static string VerificarClassificacao(int pontuacao)
    {
        if (pontuacao > 90) return "Excelente";
        if (pontuacao > 70) return "Bom";
        if (pontuacao > 50) return "Regular";
        return "Insuficiente";
    }
    
    static void Main(string[] args)
    {
        string classificacao = VerificarClassificacao(67);
        Console.WriteLine(classificacao);
    }
}