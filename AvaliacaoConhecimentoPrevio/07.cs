namespace AvaliacaoConhecimentoPrevio;

class Program {
    static void Main(string[] args)
    {
        var cidades = new List<string>()
        {
            "São Paulo",
            "Salvador",
            "Santos",
            "Recife",
            "Rio de Janeiro",
            "Belo Horizonte",
            "Curitiba",
            "Fortaleza",
            "Porto Alegre",
            "Brasília",
            "Sorocaba",
            "Santa Maria",
            "São Luís"
        };

        var novaLista = cidades.Where(cidade => cidade.StartsWith("S"));
        var novaListaOrdenada = novaLista.OrderBy(cidade => cidade);
        
        foreach (var cidade in novaListaOrdenada)
        {
            Console.WriteLine(cidade);
        }
    }
}