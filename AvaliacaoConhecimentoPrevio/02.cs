/**
 * Diferença entre int, double e string em C#:
 * - int é um tipo numérico que armazena valores inteiros, sem parte decimal.
 * - double também é um tipo numérico, mas de ponto flutuante (o computador armazena todos os dígitos do número
 * e onde fica o ponto da parte decimal) com precisão dupla (64 bits).
 * - string é um tipo que armazena uma sequência de caracteres, geralmente palavras e textos.
 *
 * Para converter string para int:
 * - Os métodos são int.Parse(), Convert.ToInt32() e int.TryParse().
 * - Os métodos int.Parse() e Convert.ToInt32() lançam exceção, que pode ser capturada com try-catch.
 * - O método int.TryParse() retorna true ou false para a conversão, não uma exceção.
 */

namespace AvaliacaoConhecimentoPrevio;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite um número inteiro: ");
        string entrada = Console.ReadLine();

        try
        {
            int numero = Convert.ToInt32(entrada);
            Console.WriteLine($"Valor inteiro: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: o valor digitado não é um número inteiro válido.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Erro: o número digitado é muito grande ou muito pequeno.");
        }
    }
}