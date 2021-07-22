using System;
using Libraryclass;
namespace Biblioteca_V1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicializando a classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de setar o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores da classe
            Console.WriteLine("Autor: "+ MinhaBiblioteca.Autor );
            Console.WriteLine("Titulo: "+MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: "+MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: "+MinhaBiblioteca.Status);
            Console.WriteLine();

            //Inicializando a classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
            //imprimindo os valores da classe
            Console.WriteLine("Autor: "+ MeusLivros.Autor);
            Console.WriteLine("Titulo: "+MeusLivros.Titulo);
            Console.WriteLine("Paginas: "+MeusLivros.Paginas);
            Console.WriteLine("Status: "+MeusLivros.Status);
            Console.WriteLine();
        }
    }
}
