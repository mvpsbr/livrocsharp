using System;
using System.Collections.Generic;

namespace livrocsharp {    
    
    public class ExemploList 
    {        
    static void Testa()
        {
            List<string> nomesFuncionarios = new List<string>();

            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");
            
            Console.WriteLine();
            // foreach(string pessoa in nomesFuncionarios)
            // {
            //     Console.WriteLine(pessoa);
            // }

            //Console.WriteLine(nomesFuncionarios[0]);
            //removendo Maria da lista
            nomesFuncionarios.RemoveAt(0);
            Console.WriteLine(nomesFuncionarios[0]);
        }
    }
}