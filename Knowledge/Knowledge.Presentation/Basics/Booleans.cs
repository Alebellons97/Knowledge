using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Presentation.Basics
{
    static public class Booleans
    {
        static bool result = false;

        static void Operators()
        {
            // AND : enreambi i booleani devono essere veri per ottenere vero
            result = true && true; // => true
            result = true && false; // => false
            result = false && true; // => false
            result = false && false; // => false

            // OR : almeno un booleano deve essere vero per ottenere vero
            result = true || true; // => true
            result = true || false; // => true
            result = false || true; // => true
            result = false || false; // => false

            // XOR : almeno un booleano deve essere vero per ottenere vero

            result = true ^ true; // => False
            result = true ^ false; // => True
            result = false ^ true; // => True
            result = false ^ false; // => False

            // NOT : inverte il valore booleano, true => false; false => true

            result = !false; // => true
            result = !true; // => false

            string word1 = "Ciao";
            string word2 = "ciao";

            result = word1 == word2;

            int a = 10;
            int b = 11;

            result = a < b;
        }

    }
}
