using System;
using System.Linq.Expressions;

namespace Esercizio_Date
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GetdateFromInput();
            RegisterToCityHall();

            static void GetdateFromInput()
            {
                Console.WriteLine("Inserire una  data in formato aaaa/mm/gg\n");
                string input = Console.ReadLine();

                DateTime result;

                if (DateTime.TryParse(input, out result))
                {
                    Console.WriteLine($" Hai inserito la seguente data: {result}\n");
                }
                else
                {
                    Console.WriteLine($"La data inserita non è valida!\n");
                    GetdateFromInput();
                    
                }

            }
            static void RegisterToCityHall()
            {
                Console.WriteLine("Sei maggiorenne? Premi \"y\" per sì e \"n\" per no");
                string maggiorenneConferma = Console.ReadLine();
                if (maggiorenneConferma == "y")
                {
                    Console.WriteLine("Procedi con l'inserimento dei dati anagrafici per completare la registrazione");
                }else if (maggiorenneConferma == "n")
                {
                    Console.WriteLine("Devi essere maggiorenne per poterti iscrivere");
                }else{
                    Console.WriteLine("Errore nell'inserimento");
                    RegisterToCityHall();
                }

            }

        }
    }  
}
