using System;
using static System.Console;

namespace livrocsharp
{
    public static class MetodosExtensao
    {
        static void ExemploMetodosExtensao(string[] args)
        {
            WriteLine(DateTime.Today.FormatarData("dd/MMM/yyyy"));
            WriteLine(DateTime.Today.FormatarData("dddd dd/MMM/yyyy"));
            WriteLine(DateTime.Today.FormatarData("MMMM yyyy"));
            WriteLine(DateTime.Today.FormatarData("yyyy"));

            decimal valor = 5800.78M;
            WriteLine(valor.Formatar("R$ ##,##0.00"));

            WriteLine($"{4578.87M.Formatar("C2")}");
            WriteLine(4578.87M.Formatar("C2"));
            ReadLine();
        }

        // o método de extensão DEVE ser static
        public static string FormatarData(
            this DateTime data, string formato)
            => data.ToString(formato);

        public static string Formatar(
            this decimal valor, string formato)
            => valor.ToString(formato);
    }
}
