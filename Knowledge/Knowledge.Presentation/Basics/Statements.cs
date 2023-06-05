using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Presentation.Basics
{
    public class Statements
    {

        static void If()
        {
            bool shouldExecute = true;

            if(shouldExecute)
            {
                // codice

                if(1 == 1)
                {
                    // codice
                }
            }


        }

        static void While()
        {
            bool shouldContinue = true;
            int counter = 0;
            int result = default;

            while((shouldContinue && 5 > 4 && "ciao".Length > 0) && counter < 10) // eseguo questo codice finche l'argomento del while e' vero
            {
                int randomNumber = new Random().Next(10); // numero a caso

                if(randomNumber == 0 || randomNumber == 5)         
                    continue; // salta alla fine del ciclo, e continua con la prossima iterazione
                      
                if(randomNumber > 8)
                    break; // esce dal ciclo

                if(randomNumber == 6)
                    shouldContinue = false; // rende l'argomento del while falso, quindi sara' l'ultima iterazione

                counter++;
            }

            Console.WriteLine(counter);
        }

        static void ForEach() 
        {
            // IEnumerable e' l'interfaccia da che tutti gli oggetti iterabili devono implementare
            List<int> integers = new List<int>() { 10, 20, 30, 40, 50 };
            int result = default;

            foreach(int item in integers) // esegue il ciclo per ogni elemento della lista
            {
                // integers.Add(100); // nota: non posso modificare la lista all'interno del ciclo
                if(item == 30)
                    continue; // salta alla fine del ciclo, e continua con la prossima iterazione
                if(item == 40)
                    break; // esce dal ciclo

                result++;
            }

        }

        static void For() 
        {
            int result = default;

            for(int i = 0; i < 10; i++) // utilizza un contatore e lo incrementa ad ogni iterazione
            {
                int randomNumber = new Random().Next(10); // numero a caso

                if(randomNumber == 0 || randomNumber == 5)
                    continue; // salta alla fine del ciclo, e continua con la prossima iterazione
                if(randomNumber > 8)
                    break; // esce dal ciclo

                result++;
            }
        }
    }
}
