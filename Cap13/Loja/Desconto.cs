using System;

namespace Loja
{
    public class Desconto
    {
        public int Calcule(Cor cor) => cor switch
        {
            Cor.Vermelho => 10,
            Cor.Verde => 20,
            Cor.Azul => 30,
            _ => 0
        };
    }
}