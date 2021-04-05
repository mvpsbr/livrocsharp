using static System.Console;
using System;
using System.Linq;

namespace livrocsharp
{
    class funcoesTexto
    {
        static void Main(string[] args)
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

            WriteLine("Remove - extrai x caracteres a partir da esquerda da expressão");
            WriteLine($"texto esquerdo: {empresa.Remove(9)}");
            
            WriteLine("Replace - troca o conteúdo da expressão");
            empresa.Replace("Microsoft", "Google");
            WriteLine($"texto trocado: {empresa}");
            
            WriteLine("Split - divide e extrai cada palavra em um array");
            string NivelLivro = "Este livro é básico de C#.";
            string[] blocos = NivelLivro.Split(' ');
            foreach (var exp in blocos)
            {
                WriteLine($"texto: {exp}");
            }
            WriteLine($"Qtde de palavras: {blocos.Count()}");

            WriteLine("Substring é usado para extrair parte do texto");
            WriteLine(NivelLivro.Substring(5, 14));

            WriteLine("IsNullOrEmpty  verifica se a string está nula ou vazia");
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
