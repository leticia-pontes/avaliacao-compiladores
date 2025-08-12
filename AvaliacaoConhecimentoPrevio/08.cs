/**
 * Polimorfismo: permite que objetos diferentes (de classes filhas de uma mesma classe pai) sejam
 * tratados como um só tipo, executando métodos específicos de cada um.
 * Isso facilita escrever código genérico que funciona para várias classes relacionadas.
 */

namespace AvaliacaoConhecimentoPrevio;

public abstract class FormaGeometrica
{
    public abstract double CalcularArea();
}

public class Retangulo : FormaGeometrica
{
    public double Altura { get; set; }
    public double Largura { get; set; }

    public Retangulo(double altura, double largura)
    {
        this.Altura = altura;
        this.Largura = largura;
    }
    
    public override double CalcularArea()
    {
        return Altura * Largura;    
    }
}

public class Circulo : FormaGeometrica
{
    public double Raio { get; set; }

    public Circulo(double raio)
    {
        this.Raio = raio;
    }

    public override double CalcularArea()
    {
        return Math.PI * (Raio * Raio);
    }
}

class Program {
    static void Main(string[] args)
    {
        double area = 0;
        
        Retangulo r = new Retangulo(5, 3);
        area = r.CalcularArea();
        Console.WriteLine($"Área do retângulo: {area}");

        Circulo c = new Circulo(5);
        area = c.CalcularArea();
        Console.WriteLine($"Área do círculo: {area:F2}");
    }
}