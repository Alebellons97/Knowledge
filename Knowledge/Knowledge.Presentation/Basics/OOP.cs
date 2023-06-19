using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Presentation.Basics
{
    public class OOP
    {
        public class Calciatore
        {
            // Rappresentazione dati dell' oggetto che stai rappresentando
            public string Nome { get; set; }
            public int NumeroMaglia { get; set; }
            public string Ruolo { get; set; }
            public string Squadra { get; set; }

            // Valore che non puo' essere modificato dall'esterno
            private bool hasPalla = false;


            // Via per istanzare un' oggetto di questa classe 
            public Calciatore(string nome)
            {
                Nome = nome;
            }

            // Comportamento dell' oggetto
            public void Ricevi()
            {
                Console.WriteLine($"il giocatore {this.Nome} ha ricevuto la palla");
                this.hasPalla = true;
            }

            public void Passaggio(Calciatore compagno)
            {
                if(!this.hasPalla)
                {
                    Console.WriteLine($"il giocatore {this.Nome} non ha la palla");
                    return;
                }

                hasPalla = false;
                Console.WriteLine($"il giocatore {this.Nome} ha passato la palla a {compagno.Nome}");

                compagno.Ricevi();
            }

            public void Tiro()
            {
                Console.WriteLine($"il giocatore {this.Nome} ha tirato in porta");

                if(new Random().Next(2) == 1)
                {
                    Console.WriteLine("e ha fatto goal");
                }
                else
                {
                    Console.WriteLine("e ha tirato fuori");
                }                
            }

        }

        public static void DataStructure()
        {
            // Simulazione partitella

            Calciatore delPiero = new Calciatore("Del piero");
            Calciatore ronaldo = new Calciatore("Cristiano ronaldo");

            delPiero.Ricevi();

            delPiero.Passaggio(ronaldo);

            delPiero.Passaggio(ronaldo);

            ronaldo.Tiro();
        }

        public static void DataStructureExample()
        {
            /// Crea 4 giocatori, due per squadra (modifica il costruttore per assegnare anche la squadra).
            /// simula una partita
        }


    }
}
