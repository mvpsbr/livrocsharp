using System;
using Libraryclass;
namespace Biblioteca_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicializando nossa nova classe Fotos
            Fotos MinhasFotos = new Fotos("Colorida");
            MinhasFotos.AnoPublicacao = 2021;
            MinhasFotos.MesPublicacao = 3;
            MinhasFotos.Autor = "Desconhecido";
            MinhasFotos.Titulo = "Vida Eterna";
            MinhasFotos.Paginas = 1;
            MinhasFotos.Status = true;
                //imprimindo os valores de minha classe
            Console.WriteLine("Foto Tipo: "+ MinhasFotos.Tipo);
            Console.WriteLine("Foto Mes: "+ MinhasFotos.MesPublicacao);
            Console.WriteLine("Foto Ano: "+ MinhasFotos.AnoPublicacao);
            Console.WriteLine("Foto Autor: "+ MinhasFotos.Autor);
            Console.WriteLine("Foto Titulo: "+MinhasFotos.Titulo);
            Console.WriteLine("Foto Paginas: "+MinhasFotos.Paginas);
            Console.WriteLine("Foto Status: "+MinhasFotos.Status);
            Console.WriteLine();

            //inicializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3,2021);
            //Inicializando as outas propriedades da classe que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //imprimindo os valores de minha classe
            Console.WriteLine("Revista Mes: "+ MinhasRevistas.MesPublicacao);
            Console.WriteLine("Revista Ano: "+ MinhasRevistas.AnoPublicacao);
            Console.WriteLine("Revista Autor: "+ MinhasRevistas.Autor);
            Console.WriteLine("Revista Titulo: "+MinhasRevistas.Titulo);
            Console.WriteLine("Revista Paginas: "+MinhasRevistas.Paginas);
            Console.WriteLine("Revista Status: "+MinhasRevistas.Status);
            Console.WriteLine();

            //Inicializando nossa classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de "setar" o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores de minha classe
            Console.WriteLine("Autor: "+ MinhaBiblioteca.Autor);
            Console.WriteLine("Titulo: "+MinhaBiblioteca.Titulo);
            Console.WriteLine("Paginas: "+MinhaBiblioteca.Paginas);
            Console.WriteLine("Status: "+MinhaBiblioteca.Status);
            Console.WriteLine();

            //Inicializando nossa classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
            //imprimindo os valores de minha classe
            Console.WriteLine("Autor: "+ MeusLivros.Autor);
            Console.WriteLine("Titulo: "+MeusLivros.Titulo);
            Console.WriteLine("Paginas: "+MeusLivros.Paginas);
            Console.WriteLine("Status: "+MeusLivros.Status);
            Console.WriteLine();
        }
    }
}
