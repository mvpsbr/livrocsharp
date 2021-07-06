using System;

namespace Componentes
{
    public class CalculoGeral
    {
        public int valor { get; set; }
        public int dias { get; set; }
        
        public int? FaturamentoMedioDiario() => valor / dias;
    }

    public class DescontoGeral
    {
        public enum Cores
        {
            Vermelho = 1,
            Verde = 2,
            Azul = 3
        }
        public static double DescontoPorCor(double valor, Cores cor) =>
        cor switch
        {
            Cores.Vermelho => valor * 0.9,
            Cores.Verde => valor * 0.8,
            Cores.Azul => valor * 0.7,
            _ => valor,
        };
    }
}
