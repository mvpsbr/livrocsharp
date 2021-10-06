using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cap08
{
    class Program
    {
        static void Main(string[] args)
        {

            Exemplo_Where();
            //Exemplo_Count();
            //Exemplo_Sum();
            //Exemplo_Max();
            //Exemplo_Min();
            //Exemplo_Average();
            //Exemplo_Reverse();
            //Exemplo_OrderBy();
            //Exemplo_OrderByDescending();
            //Exemplo_Take();
            //Exemplo_TakeWhile();
            //Exemplo_First();
            //Exemplo_First_SobreCarga();
            //Exemplo_First_SobreCargaException();
            //Exemplo_FirstOrDefault();
            //Exemplo_LastAndLastOrDefault();
            //Exemplo_Skip();
            //Exemplo_Concat();
            //Exemplo_ElementAt();
            //Exemplo_SingleException();
            //Exemplo_Single();
            //Exemplo_Select();
            //Exemplo_Func();
            //Exemplo_Queryable();
        }

        static void Exemplo_01()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var numerosFiltrados = from n in numeros where n > 5 select n;

            foreach (var numero in numerosFiltrados)
            {
                Console.WriteLine(numero);
            }

        }

        static void Exemplo_Where()
        {
            // Coleção de pessoas
            var pessoas = new[]
            {
                "Marcos Santos",
                "João Silva",
                "Claudenir Andrade",
                "Renato Silva",
                "Pedro Martins"
            };

            // Filtro de pessoas que contém nome Silva
            var pessoasFiltradas = pessoas.Where(p => p.Contains("Silva"));

            // Iteração com as pessoas filtradas
            foreach (var pessoa in pessoasFiltradas)
            {
                // Imprime no console o nome da pessoa
                Console.WriteLine(pessoa);
            }

            // Resultado:
            //Joao Silva
            //Renato Silva
        }

        static void Exemplo_Count()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Faz contagem em toda coleção
            var countTotal = numeros.Count();

            // Faz contagem coleção com filtro
            var countParcial = numeros.Count(n => n > 5);

            // Imprime Contagem
            Console.WriteLine(countTotal);
            Console.WriteLine(countParcial);

            // Resultado:
            //10
            //5
        }

        static void Exemplo_Sum()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Soma todos elementos da coleção
            var somaTotal = numeros.Sum();

            // Soma o elemeto da coleção multiplicado por 2
            var somaComMultiplicacao = numeros.Sum(n => n * 2);

            // Imprime Soma
            Console.WriteLine(somaTotal);
            Console.WriteLine(somaComMultiplicacao);

            // Resultado:
            //55
            //110
        }

        static void Exemplo_Max()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Recupera o valor máximo de um elemento da coleção
            var maxTotal = numeros.Max();

            // Valor máximo do elemeto da coleção multiplicado por 2
            var maxComMultiplicacao = numeros.Max(n => n * 2);

            // Imprime valor máximo
            Console.WriteLine(maxTotal);
            Console.WriteLine(maxComMultiplicacao);

            // Resultado:
            //10
            //20
        }

        static void Exemplo_Min()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Recupera o valor mínimo de um elemento da coleção
            var minTotal = numeros.Min();

            // Valor mínimo do elemeto da coleção multiplicado por 2
            var minComMultiplicacao = numeros.Min(n => n * 2);

            // Imprime valor mínimo
            Console.WriteLine(minTotal);
            Console.WriteLine(minComMultiplicacao);

            // Resultado:
            //1
            //2
        }

        static void Exemplo_Average()
        {
            var numeros = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            // Média dos elementos da coleção
            var media = numeros.Average();

            // Imprime valor da média
            Console.WriteLine(media);

            // Resultado:
            //1
            //2
        }

        static void Exemplo_Reverse()
        {
            var numeros = new[] { 1, 2, 3 };
            // Executa o operador reverso
            var numerosReverso = numeros.Reverse();
            // Faz iteração em numerosReverso
            foreach (var numero in numerosReverso)
            {
                // Imprime número
                Console.WriteLine(numero);
            }

            // Resultado:
            //3
            //2
            //1
        }

        static void Exemplo_OrderBy()
        {
            var numeros = new[] { 3, 1, 2 };
            // Executa o operador de ordenação na coleção
            var numerosOrdenados = numeros.OrderBy(n => n);
            // Faz iteração sobre a variável numerosOrdenados
            foreach (var numero in numerosOrdenados)
            {
                // Imprime número
                Console.WriteLine(numero);
            }

            // Resultado:
            //1
            //2
            //3
        }

        static void Exemplo_OrderByDescending()
        {
            var numeros = new[] { 3, 1, 2 };
            // Executa o operador de ordenação na coleção
            var numerosOrdenados = numeros.OrderByDescending(n => n);
            // Faz iteração sobre a variável numerosOrdenados
            foreach (var numero in numerosOrdenados)
            {
                // Imprime número
                Console.WriteLine(numero);
            }
            // Resultado:
            //3
            //2
            //1
        }

        static void Exemplo_Take()
        {
            var numeros = new[] { 1, 2, 3, 4 };
            // Executa o operador de paginação take na coleção
            var doisElementos = numeros.Take(2);
            // Faz iteração sobre a variável doisElementos
            foreach (var numero in doisElementos)
            {
                // Imprime número
                Console.WriteLine(numero);
            }
            // Resultado:
            //1
            //2
        }

        static void Exemplo_TakeWhile()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação take na coleção
            var items = numeros.TakeWhile(n => n < 6);
            // Faz iteração sobre a variável doisElementos
            foreach (var numero in items)
            {
                // Imprime número
                Console.WriteLine(numero);
            }
            // Resultado:
            //5
            //4
        }


        static void Exemplo_First()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação First na coleção
            var numero = numeros.First();
            // Imprime número
            Console.WriteLine(numero);
            // Resultado:
            //5
        }

        static void Exemplo_First_SobreCarga()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação First na coleção
            var numero = numeros.First(p => p == 9);
            // Imprime número
            Console.WriteLine(numero);
            // Resultado:
            //9
        }

        static void Exemplo_First_SobreCargaException()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação First na coleção
            var numero = numeros.First(p => p == 10);
            // Exception:
            // System.InvalidOperationException: Sequence contains no matching element
        }

        static void Exemplo_FirstOrDefault()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação FirstOrDefault na coleção
            var numero = numeros.FirstOrDefault(p => p == 10);
            // Imprime número
            Console.WriteLine(numero);
            // Resultado:
            // 0
        }

        static void Exemplo_LastAndLastOrDefault()
        {
            var numeros = new[] { 5, 4, 9, 6, 7, 2 };
            // Executa o operador de paginação LastOrDefault na coleção
            var numeroDefault = numeros.LastOrDefault(p => p == 10);
            // Imprime número
            Console.WriteLine(numeroDefault);
            // Resultado:
            // 0
            // Executa o operador de paginação last na coleção
            var ultimo = numeros.Last();
            // Imprime número
            Console.WriteLine(ultimo);
            // Resultado:
            // 2
        }

        static void Exemplo_Skip()
        {
            var numeros = new[] { 1, 2, 3, 3, 3, 4 };
            // Executa o operador de paginação Skip na coleção
            var numerosPaginados = numeros.Skip(3);
            // Faz iteração em numerosPaginados
            foreach (var numero in numerosPaginados)
            {
                // Imprime número
                Console.WriteLine(numero);
            }

            // Resultado:
            //3
            //3
            //4
        }


        static void Exemplo_Concat()
        {
            var colecao1 = new[] { 1, 2, 3 };
            var colecao2 = new[] { 5, 6, 7 };

            // Executa o operador de junção concat na coleção
            var numerosConcatenados = colecao1.Concat(colecao2);

            // Faz iteração em numerosConcatenados
            foreach (var numero in numerosConcatenados)
            {
                // Imprime número
                Console.WriteLine(numero);
            }

            // Resultado:
            //1
            //2
            //4
            //5
            //6
            //7
        }

        static void Exemplo_ElementAt()
        {
            var colecao1 = new[] { 1, 2, 3 };
            // Executa o operador de paginação ElementAt na coleção
            var numero = colecao1.ElementAt(1);
            // Imprime número
            Console.WriteLine(numero);
            // Resultado:
            //2
        }


        static void Exemplo_SingleException()
        {
            var numeros = new[] { 1, 2, 2, 3 };
            // Executa o operador de paginação ElementAt na coleção
            var numero = numeros.Single(p => p == 2);
        }

        static void Exemplo_Single()
        {
            var numeros = new[] { 1, 2, 2, 3 };
            // Executa o operador de paginação ElementAt na coleção
            var numero = numeros.Single(p => p == 3);
            // Imprime número
            Console.WriteLine(numero);
            // Resultado:
            //3
        }

        static void Exemplo_Select()
        {
            var numeros = new[] { 1, 2, 3 };
            // Executa o operador de paginação ElementAt na coleção
            var categorias = numeros.Select(p =>
            new
            {
                Id = p,
                Descricao = $"Categoria {p}"
            });
            // Faz iteração na variável categorias
            foreach (var categoria in categorias)
            {
                // Imprime categoria
                Console.WriteLine($"Id: {categoria.Id}, Descricao: {categoria.Descricao}");
            }
            // Resultado:
            //Id: 1, Descricao: Categoria 1
            //Id: 2, Descricao: Categoria 2
            //Id: 3, Descricao: Categoria 3
        }

        static void Exemplo_Func()
        {
            var numeros = new[] { 1, 2, 3 };
            // Função (entrada inteiro, saída boleano)
            Func<int, bool> funcao = i => i > 2;
            var resultado = numeros.Where(funcao);
            // Faz iteração na variável resultado
            foreach (var numero in resultado)
            {
                // Imprime número
                Console.WriteLine(numero);
            }
            // Resultado:
            //3
        }

        static void Exemplo_Queryable()
        {
            var numeros = new[] { 1, 2, 3 }.AsQueryable();
            // Expressão  
            Expression<Func<int, bool>> funcao = p => p > 2;
            // Filtro
            var resultado = numeros.Where(funcao);
            // Faz iteração na variável resultado
            foreach (var numero in resultado)
            {
                // Imprime número
                Console.WriteLine(numero);
            }
            // Resultado:
            //3
        }

    }
}
