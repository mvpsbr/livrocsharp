using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class funcoesTexto
    {
        static void ExemplosTextos()
        {
            WriteLine("------ Funções de Textos -------");
            string empresa = " Microsoft Corporation   ";
            WriteLine("TRIM - retira os espaços em branco antes e após a expressão");
            WriteLine($"Nome sem espaços: {empresa.Trim()}");

            WriteLine("Length - retorna a qtde de caracteres");
            WriteLine($"Tamanho do texto: {empresa.Length}");
            empresa = empresa.Trim();
            WriteLine($"Tamanho do texto após o TRIM(): {empresa.Length}");

            WriteLine("ToUpper - converte todo os caracteres para maiúsculo");
            WriteLine($"Converte para maiúsculo: {empresa.ToUpper()}");

            WriteLine("ToLower - converte todo os caracteres para minúsculo");
            WriteLine($"Converte para minúsculo: {empresa.ToLower()}");

            var nomeUpper = "AIRTON SENNA";
            var nomeLower = "airton senna";
            // comparação 1
            if (nomeUpper == nomeLower)
                WriteLine("1 - nomes iguais");
            else
                WriteLine("1 - nomes diferentes");

            // comparação 2
            if (nomeUpper.ToLower() == nomeLower)
                WriteLine("2 - nomes iguais");
            else
                WriteLine("2 - nomes diferentes");

            // comparação 3
            if (nomeUpper.Equals(nomeLower, StringComparison.OrdinalIgnoreCase))
                WriteLine("3 - nomes iguais");
            else
                WriteLine("3 - nomes diferentes");

            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"texto esquerdo: {empresa.Remove(9)}");
            
            WriteLine("Captura apenas o primeiro nome das pessoas");
            string[] nomes = {"Fabricio dos Santos", "José da Silva", "Roberta Brasil"};
            foreach(var n in nomes)
            {
                WriteLine($"{n.Remove(n.IndexOf(" "))}");
            }

            WriteLine("Replace - troca o conteúdo da expressão");
            WriteLine($"texto atual: {empresa}");
            var novaEmpresa = empresa.Replace("Microsoft", "Google");
            WriteLine($"texto trocado: {novaEmpresa}");

            WriteLine("Split - divide e extrai cada palavra em um array");
            string NivelLivro = "Este livro é básico de C#.";
            string[] blocos = NivelLivro.Split(' ');
            var contador = 1;
            foreach (var exp in blocos)
            {
                WriteLine($"texto {contador++}: {exp}");
            }
            WriteLine($"Qtde de palavras: {blocos.Count()}");

            WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(NivelLivro.Substring(5, 14));
            // array com frutas
            string[] cesta = {"5 Laranjas", "10 Goiabas vermelhas", "5 Pêssegos doces", "5 Bananas"};
            int qtde = 0;
            foreach(var p in cesta)
            {
                // p.IndexOf(" ") +1 retorna a posição inicial logo após o número
                // ex: 5 Laranjas = posição 1+1 = 2
                WriteLine($"{p.Substring(p.IndexOf(" ") +1 )}");
                
                // Ler apenas os números para somar na variável qtde
                qtde += Convert.ToInt32(p.Substring(0, p.IndexOf(" ")));
            }
            WriteLine($"Qtde total: {qtde:n0}");


            WriteLine("IsNullOrEmpty verifica se a string está nula ou vazia");
            string nome = "Renato";
            string sobrenome = null;
            if (!String.IsNullOrEmpty(nome) && !String.IsNullOrEmpty(sobrenome))
            {
                WriteLine($"Nome completo: {nome} {sobrenome}");
            }
            else{
                WriteLine($"Nome: {nome}");
            }
        }
    }
}
