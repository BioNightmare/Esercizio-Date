using System;
using System.Linq.Expressions;

namespace Esercizio_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetdateFromInput();
            //RegisterToCityHall();

            static void GetdateFromInput()
            {
                Console.WriteLine("Inserire una  data in formato aaaa/mm/gg\n");
                string input = Console.ReadLine();
                DateTime result;

                if (DateTime.TryParse(input, out result))
                {
                    if (result <= DateTime.Now.AddYears(-18))
                    {
                        Console.WriteLine($" Hai inserito la seguente data: {result}\n Puoi procedere con l'iscrizione al comune.\n");
                    }else if(result >= DateTime.Now.AddYears(-18))
                    {
                        Console.WriteLine($" Hai inserito la seguente data: {result}\n Devi essere maggiorenne per poter poterti iscrivere al comune.\n");
                    }
                }
                else
                {
                    Console.WriteLine("La data inserita non è valida!\n");
                    GetdateFromInput();
                }

            }
        }
    }  
}
