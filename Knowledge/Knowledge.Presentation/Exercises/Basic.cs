using Knowledge.Presentation.Utils;
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

            while (nVolte < 10)
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

            if (etaInt >= 18)
            {
                Console.WriteLine("sei magg");
            }
            else Console.WriteLine("sei min");


        }

        public static void Es4()
        {
            // chiedere un numero e stampare la tabellina

            Console.WriteLine("scegli un numero");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                int risultato = numero * i;
                Console.WriteLine(risultato);
            }


        }


        public static void Es6()
        {
            // stampa il risultato della moltiplacazione dei tre numeri 



            Console.WriteLine("inserisci 3 numeri");


            int numero1 = int.Parse(Console.ReadLine());
            int numero2 = int.Parse(Console.ReadLine());
            int numero3 = int.Parse(Console.ReadLine());



          
            

            Console.WriteLine(numero3 * numero2 * numero1);


        }


        public static void Es7()
        {
            // stampa sulla consolle la somma , la moltiplicazione , sottr, divs, 2 numeri inseriti dall utente 

            Console.WriteLine("inserisci 2 numeri ");

            float numero1 = float.Parse(Console.ReadLine());
            float numero2 = float.Parse(Console.ReadLine());

            Console.WriteLine(numero1 + numero2);
            Console.WriteLine(numero1 - numero2);
            Console.WriteLine(numero1 * numero2);

            float tot;
            
            if (numero1 > numero2)
            {
                tot = numero1 / numero2;
                
            }
            else
            {
                 tot = numero2 / numero1;
            }

            Console.WriteLine(tot);

        }

        public static void Es14() 
       // conversione gradi celsius a kelvin e farha
        
        {
            Console.WriteLine("la temp in c° è :");
            float celsius = float.Parse(Console.ReadLine());

            
            Console.WriteLine(" la temp in kelvin è :");
            Console.WriteLine(TemperatureUtils.CelsiusToKelvin(celsius));
            
            Console.WriteLine(" la temp in far è : ");
            Console.WriteLine(TemperatureUtils.CelsiusToFahrenheit(celsius));
            



        }




    }
}
