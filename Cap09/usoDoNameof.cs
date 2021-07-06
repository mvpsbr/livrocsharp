using System;
using static System.Console;

namespace livrocsharp
{
   class usoDoNameof
   {
      static void UsandoNameOf()
      {
         try
         {
            string produto = "peixe";
            DateTime lancto = new DateTime( 2010, 5, 15 );
            WriteLine($"o {produto} tem {idade(lancto.Year)} anos");
            WriteLine($"o {produto} tem {idade(2023)} anos");
            // método com 2 parâmetros
            WriteLine($"o {produto} tem {PescaAutorizada(lancto.Month, lancto.Day)}");
            WriteLine($"o {produto} tem {PescaAutorizada(10, 18)}");
         }
         catch (Exception ex)
         {
             WriteLine(ex.Message);
         }

         // método com 2 parâmetros
         try
         {
            string produto = "peixe";
            DateTime lancto = new DateTime( 2010, 2, 18 );
            WriteLine($"o {produto} tem {PescaAutorizada(lancto.Month, lancto.Day)}");
            //WriteLine($"o {produto} tem {PescaAutorizada(10, 12)}");
            WriteLine($"o {produto} tem {PescaAutorizada(7, 18)}");
         }
         catch (Exception ex)
         {
             WriteLine(ex.Message);
         }
      }

      public static int idade(int pAno)
      {
         if (pAno > DateTime.Today.Year)
         {
               throw new Exception($"ano inválido {nameof(pAno)}");
         }
         return DateTime.Today.Year - pAno;
      }

      public static string PescaAutorizada(int pMes, int pDia)
      {
         if (pDia < 16) {
            throw new Exception($"primeira quinzena {nameof(pDia)}");
         }
         if (pMes >= 5 && pMes <= 8)
         {
               throw new Exception($"pesca no inverno {nameof(pMes)}");
         }
         return "Pesca autorizada";
      }
   }
}