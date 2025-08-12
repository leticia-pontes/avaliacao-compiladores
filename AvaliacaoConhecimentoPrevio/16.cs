abstract class Forma
{
    public abstract void Desenhar();
}

class Circulo : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("BOLA BOLA");
    }
}

class Quadrado : Forma
{
    public override void Desenhar()
    {
        Console.WriteLine("NÃO BOLA BOLA");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Circulo circulo = new Circulo();
        Quadrado quadrado = new Quadrado();
        quadrado.Desenhar();
        circulo.Desenhar();
    }
}

// HERANÇA: A herança é um conceito que permite criar novas classes com base em classes existentes.
// A classe que serve como base à chamada de classe pai ou classe base, enquanto a nova classe é chamada
// de classe filha ou classe derivada. A herança permite que a classe filha herde propriedades e métodos da classe pai.

// POLIMORFISMO:O polimorfismo é um conceito que permite que objetos de diferentes classes sejam tratados de maneira uniforme.
// Em C#, isso é alcançado por meio de m�todos virtuais e da substituição de métodos em classes derivadas. O polimorfismo permite
// que você chame o mesmo método em objetos de classes diferentes, obtendo comportamentos específicos de cada classe.