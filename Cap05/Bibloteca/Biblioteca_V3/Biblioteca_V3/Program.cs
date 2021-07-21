using System;
using Libraryclass;
namespace Biblioteca_V3
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
            Console.Write("Foto Tipo: "+ MinhasFotos.Tipo);
            Console.Write("Foto Mes: "+ MinhasFotos.MesPublicacao);
            Console.Write("Foto Ano: "+ MinhasFotos.AnoPublicacao);
            Console.Write("Foto Autor: "+ MinhasFotos.Autor);
            Console.Write("Foto Titulo: "+MinhasFotos.Titulo);
            Console.Write("Foto Paginas: "+MinhasFotos.Paginas);
            Console.Write("Foto Status: "+MinhasFotos.Status);
            Console.WriteLine();

            //inicializando nossa nova classe com herança
            Revistas MinhasRevistas = new Revistas(3,2021);
            //Inicializando as outras propriedades da classe que foram herdadas
            MinhasRevistas.Autor = "Microsoft";
            MinhasRevistas.Titulo = "MSDN Magazine";
            MinhasRevistas.Paginas = 20;
            MinhasRevistas.Status = true;
            //imprimindo os valores de minha classe
            Console.Write("Revista Mes: "+ MinhasRevistas.MesPublicacao);
            Console.Write("Revista Ano: "+ MinhasRevistas.AnoPublicacao) ;
            Console.Write("Revista Autor: "+ MinhasRevistas.Autor);
            Console.Write("Revista Titulo: "+MinhasRevistas.Titulo );
            Console.Write("Revista Paginas: "+MinhasRevistas.Paginas);
            Console.Write("Revista Status: "+MinhasRevistas.Status);
            Console.WriteLine();
            
            //Inicializando nossa classe com o construtor nulo
            Biblioteca MinhaBiblioteca = new Biblioteca();
            //Por isso a necessidade de "setar" o valor de cada propriedade
            MinhaBiblioteca.Autor = "Des Dearlove";
            MinhaBiblioteca.Titulo = "O Estilo Bill Gates de Gerir";
            MinhaBiblioteca.Paginas = 203;
            MinhaBiblioteca.Status = true;
            //imprimindo os valores de minha classe
            Console.Write("Autor: "+ MinhaBiblioteca.Autor);
            Console.Write("Titulo: "+MinhaBiblioteca.Titulo);
            Console.Write("Paginas: "+MinhaBiblioteca.Paginas);
            Console.Write("Status: "+MinhaBiblioteca.Status);
            Console.WriteLine();

            //Inicializando nossa classe com o novo construtor
            Biblioteca MeusLivros = new Biblioteca("Juan Garcia Sola", "Linguagem C", 296, true);
            //imprimindo os valores de minha classe
            Console.Write("Autor: "+ MeusLivros.Autor);
            Console.Write("Titulo: "+MeusLivros.Titulo);
            Console.Write("Paginas: "+MeusLivros.Paginas);
            Console.Write("Status: "+MeusLivros.Status);
            Console.WriteLine();

            //Estamos chamando o mesmo método porém espera-se comportamentos      
            //diferentes.
            MeusLivros.Descarte();
            Console.Write("Titulo: "+MeusLivros.Titulo);
            MinhasRevistas.Descarte();
            Console.Write("Titulo: "+MinhasRevistas.Titulo);
            MinhasFotos.Descarte();
            Console.Write("Titulo: "+MinhasFotos.Titulo);
            Console.WriteLine();
        }
    }
}
