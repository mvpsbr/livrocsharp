using Componentes;
using System;

namespace Cap03
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorFat = 100000;
            int diasFat = 50;
            CalculoGeral objFat = new CalculoGeral()
            { valor = valorFat, dias = diasFat };
            Console.WriteLine($"Faturamento: {objFat.valor:n0} - dias {objFat.dias} - Média: {objFat.FaturamentoMedioDiario():n0}");



            // acessa o desconto do seguro por cor
            double valorSeguro = 2500;
            var corVerde = DescontoGeral.Cores.Verde;
            var corAzul = DescontoGeral.Cores.Azul;
            var corVermelho = DescontoGeral.Cores.Vermelho;
            Console.WriteLine("-------- DESCONTO POR CORES ------");
            Console.WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corAzul}: {DescontoGeral.DescontoPorCor(valorSeguro, corAzul):n0}");
            Console.WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corVerde}: {DescontoGeral.DescontoPorCor(valorSeguro, corVerde):n0}");
            Console.WriteLine($"R$ bruto: {valorSeguro:n0} - desconto {corVermelho}: {DescontoGeral.DescontoPorCor(valorSeguro, corVermelho):n0}");
        }
    }
}
