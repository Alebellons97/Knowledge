using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Presentation.Exercises
{
     public static class Basic
    {
        public static void Es1()
        {
            Console.WriteLine("hello");
            Console.WriteLine("Alessandro");
        }

        public static void EsCustom()
        {

            // programma che chiede il nome all utente e riperterlo per 10 volte

            string name;
            
            Console.WriteLine("Scrivi il tuo nome");
            name = Console.ReadLine();


            int nVolte = 0;
            
            while (nVolte<10)
            {
                nVolte++;
                Console.WriteLine(" Ciao " + name);

            }












        }

        public static void Es3() 
        {   // chiedere l,eta e stampare se sei magg o min 

            Console.WriteLine("quanti anni hai ?");

            int etaInt;

            if (!int.TryParse(Console.ReadLine(), out etaInt)) { Console.WriteLine("devi scrivere un numero"); return; } 

            if ( etaInt>= 18)
            {
                Console.WriteLine("sei magg");
            }
            else Console.WriteLine("sei min");

        
        }






    }
}
