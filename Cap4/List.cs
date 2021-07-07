using System;
using System.Collections.Generic;

namespace livrocsharp {    
    
    public class ExemploList 
    {        
    static void Main()
        {
            List<string> nomesFuncionarios = new List<string>();

            nomesFuncionarios.Add("Maria");
            nomesFuncionarios.Add("João");
            nomesFuncionarios.Add("André");
            nomesFuncionarios.Add("Flávia");
            
            //removendo Maria da lista
            nomesFuncionarios.RemoveAt(0);
            Console.WriteLine(nomesFuncionarios[0]);
        }
    }
}