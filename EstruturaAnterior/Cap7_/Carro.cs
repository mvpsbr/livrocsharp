using System;
using System.Collections.Generic;

namespace livrocsharp
{
    public class Carro
    {
        public int ID { get; set; }
        public string Modelo { get; set; }
        public int Litros { get; set; }
        public double KmRodados { get; set; }
        public int AnoFabricacao { get; set; }
        public string Cor { get; set; }


        public double Consumo() => KmRodados / Litros;
        public string ConsumoString() =>
               Litros > 0 ? $"{Consumo():n2}" : "----";
        public int Idade() => DateTime.Today.Year - AnoFabricacao;

        public override string ToString() => $"{ID} - {Modelo}";

        public static List<Carro> Get()
        {
            return new List<Carro>
            {
                new Carro { ID = 1, Modelo = "Honda civic", AnoFabricacao = 2000 , KmRodados = 22000, Cor = Cores.Azul.ToString(), Litros=24 },
                new Carro { ID = 2, Modelo = "Ford GT", AnoFabricacao = 2015, KmRodados = 14000, Cor = Cores.Verde.ToString(), Litros=32  },
                new Carro { ID = 3, Modelo = "BMW X1", AnoFabricacao = 2017, KmRodados = 1000, Cor = Cores.Vermelho.ToString(), Litros=23 },
                new Carro { ID = 4, Modelo = "Honda Fit", AnoFabricacao = 2000, KmRodados = 150600, Cor = Cores.Azul.ToString(), Litros=22 },
                new Carro { ID = 5, Modelo = "Ford Landau", AnoFabricacao = 1980, KmRodados = 150520, Cor = Cores.Azul.ToString(), Litros=20 },
                new Carro { ID = 6, Modelo = "BMW X5", AnoFabricacao = 2017, KmRodados = 3500, Cor = Cores.Vermelho.ToString(), Litros=15 },
                new Carro { ID = 7, Modelo = "Jaguar S1", AnoFabricacao = 2007, KmRodados = 6000, Cor = Cores.Azul.ToString(), Litros=10 },
                new Carro { ID = 8, Modelo = "Volks Polo", AnoFabricacao = 2014, KmRodados = 5090, Cor = Cores.Verde.ToString(), Litros=12 },
                new Carro { ID = 9, Modelo = "Ferrari F40", AnoFabricacao = 2010, KmRodados = 2000, Cor = Cores.Azul.ToString(), Litros=20 },
            };
        }        
    }

    enum Cores
    {
        Vermelho = 1,
        Verde = 2,
        Azul = 3
    }
}
