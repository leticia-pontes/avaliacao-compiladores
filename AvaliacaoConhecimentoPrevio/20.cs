// 20. Corrigindo Lógica de Laço de Repetição
// O código abaixo deveria somar todos os números de 1 a 10,
// mas contém um erro. Identifique e corrija o erro, explicando
// por que a correção foi necessária.

// int soma = 0;
// int i = 0;
// do {
//   soma += i;
//   i++;
// } while (i < 10);
// Console.WriteLine(soma);

using System;

class Program
{
    static void Main()
    {
        int soma = 0;
        int i = 1; // i em 1 para incluir o número 1 na soma
        do
        {
            soma += i;
            i++;
        } while (i <= 10); // i <= 10 para incluir o número 10 na soma
        Console.WriteLine(soma);
    }
}

/*
Correção:
1- A variável 'i' foi inicializada como '0', o que significa que o primeiro número adicionado
à soma seria '0', porém para somar os números de '1' a '10' o 'i' deve começar em '1'.
2- A condição do laço era 'i < 10', o que fazia com que o laço parasse antes de incluir o número '10'
na soma. A condição foi alterada para 'i <= 10' para garantir que o número 10 seja incluído na soma.

*/