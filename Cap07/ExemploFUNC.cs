using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class ExemploFunc
    {
        static void ExemploDeFunc(string[] args)
        {
            // Func< até 16 entradas e UMA saída >
            int contador = 0;
            Func<int> numero = () => ++contador;
            WriteLine($"chamada 1: {numero()}");
            WriteLine($"chamada 2:  {numero()}");
            WriteLine($"contador: {contador}");

            // Quantos caracteres contém o texto "Visual C#"?
            Func<string, int> MetodoQtdeCaracteres = (t) => t.Length;
            WriteLine("--- Uso do Func: QtdeCaracteres ---");
            WriteLine(MetodoQtdeCaracteres("Visual C#"));

            // Qtas palavras contém uma expressão?  
            WriteLine("--- Uso do Func: QtdePalavras ---");
            Func<string, int> MetodoQtdePalavras = (t) => 
                        t.Split(' ')
                        .Where(x => x != "")
                        .Count();
            WriteLine(MetodoQtdePalavras("  Brasil     campeão    mundial de    volei  "));

            // calcular o imposto
            // salario, perc, aliquota
            // formula: salario * (perc / 100) - aliquota
            // condicao: salario <= 1000 >>> imposto = 0
            // cond ? true : false
            Func<decimal, decimal, decimal, decimal>
                Imposto = (salario, perc, aliquota) =>
                {
                    return salario <= 1000 ? 0 :
                    salario * (perc / 100) - aliquota;
                };
            WriteLine("---- cálculo do Imposto ---");
            WriteLine(Imposto(1000, 10, 10));
            WriteLine(Imposto(5000, 27.5M, 80));
            WriteLine(Imposto(23500, 32.5M, 180));

            WriteLine("---- cálculo de FUNC em coleções");
            // Fórmula: média de km rodados por ano
            // km / (today.year - ano)
            //"Modelo - Ano - Km - Cor - Litros - km/ano"
            int anoAtual = DateTime.Today.Year;
            Func<int, double, double> CalculoKmPorAno = (ano, km) =>
                ano >= anoAtual ? km : km / (anoAtual - ano);

            // Carrega a lista de carros
            var dados = Carro.Get();

            // looping para varrer todos os carros da lista
            dados.ForEach(x =>
            {
                var kmPorAno = CalculoKmPorAno(
                    x.AnoFabricacao, x.KmRodados);
                WriteLine($"{x.Modelo} | ano: {x.AnoFabricacao} | km: {x.KmRodados:n0} | litros {x.Litros} | km/ano: {kmPorAno:n0}");
            });

            ReadLine();
        }
    }
}
