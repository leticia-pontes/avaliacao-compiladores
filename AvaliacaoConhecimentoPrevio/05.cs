/**
 * Encapsulamento: é uma forma de proteger os dados de uma classe, expondo apenas uma interface pública segura.
 * Restringe o acesso e a modificação do valor a métodos públicos para que as regras de negócio sejam cumpridas.
 */

namespace AvaliacaoConhecimentoPrevio;

public class ContaBancaria
{
    private double _saldo;

    public ContaBancaria(double saldo)
    {
        this._saldo = saldo;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
            _saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor > 0 && _saldo >= valor)
        {
            _saldo -= valor;
            return true;
        }
        return false;
    }

    public double GetSaldo()
    {
        return _saldo;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ContaBancaria conta = new ContaBancaria(200);
        conta.Depositar(200);

        Console.WriteLine(conta.Sacar(500) ? $"Saldo: {conta.GetSaldo()}" : $"Saldo insuficiente.");
    }
}