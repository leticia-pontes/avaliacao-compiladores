using System;

class Program
{
    static void Main()
    {
        double precoUnitario = 50.0;
        int quantidade = 3;
        double taxaImposto = 0.1;

        double despesaTotal = CalcularDespesa(precoUnitario, quantidade, taxaImposto);
        Console.WriteLine($"Despesa total: R$ {despesaTotal:F2}");
    }

    static double CalcularDespesa(double precoUnitario, int quantidade, double taxaImposto)
    {
        double subtotal = precoUnitario * quantidade;
        double imposto = subtotal * taxaImposto;
        return subtotal + imposto;
    }
}
