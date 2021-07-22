//namespace eque irá conter a classe de controle de livros e seus metodos
namespace Libraryclass
{
    //principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //recebe o titulo do livro
        private string _Autor; //recebe o nome do autor do Livro
        private int _Paginas; ///recebe o númerp de paginas que o Livro contem
        private bool _Status; //recebe saindo (FALSE) ou entrando (TRUE) na biblioteca
    
        public Biblioteca() //Construtor sem parametros
        {

        }
        //Construtor com parametros
        public Biblioteca( string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;        
        }
        public string Titulo //Metodo para acesso a propriedade Titulo da classe
        {
            get {return _Titulo;} set { _Titulo = value;}
        }
        public string Autor 
        {
            get {return _Autor;} set { _Autor = value;}
        }
        public int Paginas
        {
            get {return _Paginas;} set { _Paginas = value;}
        }
        public bool Status
        {
            get {return _Status;} set { _Status = value;}
        }
    }
}
