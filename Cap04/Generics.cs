using System;

namespace livrocsharp {    
    
    // Declarando uma classe genérica
    public class ListaGenerica<T>
    {
        public void Adicionar(T input) { }
    }
    class TestListaGenerica
    {
        private class ExampleClass { }
        static void Testa()
        {
            // Declarando uma lista do tipo inteiro
            ListaGenerica<int> lista1 = new ListaGenerica<int>();
            lista1.Adicionar(1);

            // Declarando uma lista do tipo string
            ListaGenerica<string> lista2 = new ListaGenerica<string>();
            lista2.Adicionar("");

            /// Declarando uma lista do tipo de uma classe
            ListaGenerica<ExampleClass> lista3 = new ListaGenerica<ExampleClass>();
            lista3.Adicionar(new ExampleClass());
        }
    }
}