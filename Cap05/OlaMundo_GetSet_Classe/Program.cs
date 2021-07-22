using System;
using MinhaClasseUsuario;

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
            
            //Recuperamos pelo metodo GET o valor da mensgaem digitada para futura manipulação
            var Digitado = Pedido.Mensagem;
            //Escrevemos a nova mensagem colocando toda a mensagem em Maiuscula
            Console.WriteLine("Nova Digitação sem Espaços -> " + Digitado.ToUpper());
        }
    }
}
