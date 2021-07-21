//Name space eque irá conter a classe de controle de livros e seus metodos
namespace Libraryclass
{
    //Nossa classe para controlar as fotos
     public class Fotos : Revistas
    {
        //Propriedades da Classe
        private string _Tipo;
        //Construtor da classe neste construtor preciso referenciar a classe 
        //base por c_Revista ser uma classe já herdada de c_Biblioteca        
        public Fotos(string Tipo) : base (0,0)
        {
            _Tipo = Tipo;
        }
        public string Tipo //Metodo para acesso a propriedade da classe 
        {
            get {return _Tipo;} set { _Tipo = value;}
        }
        public override void Descarte()
        {
            this.Titulo = "A Foto foi Destruida";
        }
    }
    
    
    //Nossa nova classe para controlar as revistas
    public class Revistas : Biblioteca
    {
        //Propriedades da Classe
        private int _MesPublicacao; 
        private int _AnoPublicacao;
        //Construtor da classe        
        public Revistas(int MesPublicacao, int AnoPublicacao)
        {
            _MesPublicacao = MesPublicacao;
            _AnoPublicacao = AnoPublicacao;
        }
        public int MesPublicacao //Metodo para acesso a propriedade da classe 
        {
            get {return _MesPublicacao;} set { _MesPublicacao = value;}
        }
        public int AnoPublicacao 
        {
            get {return _AnoPublicacao;} set { _AnoPublicacao = value;}
        }
        public override void Descarte()
        {
            this.Titulo = "A Revista foi Reciclada";
        }
    }
    //Nossa principal classe de controle de livros na Biblioteca
    public class Biblioteca
    {
        private string _Titulo; //recebra o titulo do livro
        private string _Autor; //recebera o nome do autor do Livro
        private int _Paginas; ///receberá o númerp de paginas que o Livro contem
        private bool _Status; //receberá saindo (FALSE) ou entrando (TRUE) na biblioteca
        public Biblioteca() //Construtor sem parametros
        {

        }
        //Construtor com parametros note que o nome do metodo é o mesmo, estamos usando sobregarca
        public Biblioteca( string Titulo, string Autor, int Paginas, bool Status)
        {
            _Titulo = Titulo;
            _Autor = Autor;
            _Paginas = Paginas;
            _Status = Status;        
        }
        public string Titulo //Metodo para acesso a propriedade da classe "Titulo"
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

        //Criaçao do Método Descarte
        public virtual void Descarte()
        {
            _Titulo = "O Livro foi Doado";
        }
    }
}

