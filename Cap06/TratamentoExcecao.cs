using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap06
{
    public class TratamentoExcecao
    {
        public void ExemploTratamentoExcecao()
        {
            Console.WriteLine("Divisão de dois números");
            Console.WriteLine("");
            Console.WriteLine("Digite o primeiro número:");
            var strNum1 = Console.ReadLine();
            Console.WriteLine("Digite o segundo número:");
            var strNum2 = Console.ReadLine();

            try
            {
                int num1 = int.Parse(strNum1);
                int num2 = int.Parse(strNum2);
                var divisao = num1 / num2;
                Console.WriteLine($"A divisão de {num1} por {num2} é {divisao}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Erro de Divisão por Zero: {ex.Message}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Erro de Formatação: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Sempre vai executar o Finally");
            }
            Console.WriteLine("Fim");
        }

    }
}
