using System;

namespace MinhaPrimeiraClasse
{
    class ProgramaPrincipal
    {
        static void Main(string[] args)
        {
            //Criamos o objeto Pedido herdado da clase InteracaoUsuario    
            InteracaoUsuario Pedido = new InteracaoUsuario();
            
            //Invocamos os metodos do objeto Pedido herdado da classe mãe InteracaoUsuario
            Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao();

            //Recupero pelo metodo GET o valor da mensgaem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;
            //Escrevo a nova mensagem colocando toda a mensagem em Maiuscula
            Console.WriteLine("Nova Digitação sem Espaços -> " + Digitado.ToUpper());
        }
    }
    //Criamos a Classe InteracaoUsuario com dois metodos principais
    //Metodo que solicita a digitacao de algo no terminal
    //Metodo que mostra o que retorna o que foi digitado
    class InteracaoUsuario
    {
        private string _MensagemDigitada;
         public string Mensagem
        {
            get
            {
                return _MensagemDigitada;
            }
            set
            {
                _MensagemDigitada = value;
            }
        }
        public void SolicitarDigitacao()
        {
            _MensagemDigitada =  Console.ReadLine();
        }
        public void MostrarDigitacao( )
        {
            Console.WriteLine(_MensagemDigitada);
        }
    }
   
}
