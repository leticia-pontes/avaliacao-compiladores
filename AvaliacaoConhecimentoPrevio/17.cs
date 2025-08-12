int numero;
while (true)
{
    Console.Write("Digite um número: ");
    string entrada = Console.ReadLine();

    try
    {
        numero = int.Parse(entrada);
        break;
    }
    catch (FormatException)
    {
        Console.WriteLine("Erro: Por favor, digite um número válido.");
    }
}

Console.WriteLine($"Número válido digitado: {numero}");