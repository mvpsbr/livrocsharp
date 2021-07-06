using System;
using static System.Console;

namespace livrocsharp
{
    class ParametrosOpcionais
    {
        // regra: obrigatórios DEVEM vir antes dos opcionais
        static decimal Faturamento(
               decimal qtde, decimal preco = 10, decimal bonus = 5)
                => qtde * preco + bonus;

        static void ExemploParametrosOpcionais(string[] args)
        {
            WriteLine("Parâmetros Opcionais");
            WriteLine(Faturamento(500, 5, 10));
            WriteLine("Parâmetros 1 e 2");
            WriteLine(Faturamento(50, 12));
            WriteLine("Parâmetros 1 e 3");
            WriteLine(Faturamento(50, bonus: 10));
            ReadLine();
        }
    }
}
