using System;
using static System.Console;

namespace livrocsharp
{
   class usoDoNameof
   {
      static void Main()
      {
         try
         {
            string produto = "peixe";
            DateTime lancto = new DateTime( 2010, 5, 15 );
            WriteLine($"o {produto} tem {idade(lancto.Year)} anos");
            WriteLine($"o {produto} tem {idade(2023)} anos");
         }
         catch (Exception ex)
         {
             WriteLine(ex.Message);
         }



// #if DEBUG
//     services.AddDbContextFactory<ContactContext>(opt =>
//         opt.UseSqlite($"Data Source={nameof(ContactContext.ContactsDb)}.db")
//         .EnableSensitiveDataLogging());
// #else
//     services.AddDbContextFactory<ContactContext>(opt =>
//         opt.UseSqlite($"Data Source={nameof(ContactContext.ContactsDb)}.db"));
// #endif

         ReadLine();

      }

      public static int idade(int pAno)
        {
            if (pAno > DateTime.Today.Year)
            {
                throw new Exception($"ano invalido {nameof(pAno)}");
            }
            return DateTime.Today.Year - pAno;
        }
   }
}