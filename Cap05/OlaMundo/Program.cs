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
            var Digitado = Pedido.SolicitarDigitacao();
            Pedido.MostrarDigitacao(Digitado);
        }
    }

    //Criamos a Classe c_InteracaoUsuario com dois metodos principais
    //Método que solicita a digitação de algo no terminal
    //Método que mostra o que retorna o que foi digitado
    class InteracaoUsuario
    {
        public string SolicitarDigitacao()
        {
            return Console.ReadLine();
        }
        public void MostrarDigitacao(string Digitado)
        {
            Console.WriteLine(Digitado);
        }
    }
}
