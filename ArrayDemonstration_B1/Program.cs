using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemonstration_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Basic();
            Console.ReadLine();
        }

        static void Basic()
        {
            // Lottozahlen in einem Array speichern
            int[] lottozahlen = { 7, 14, 23, 34, 42, 48 };

            // Zugriff auf Lottozahlen
            Console.WriteLine("Die erste Lottozahl: " + lottozahlen[0]);  // Ausgabe: 7
            Console.WriteLine("Die dritte Lottozahl: " + lottozahlen[2]); // Ausgabe: 23

            // Ändern einer Lottozahl
            lottozahlen[5] = 50;
            Console.WriteLine("Geänderte Lottozahl: " + lottozahlen[5]); // Ausgabe: 50

            // Iteration über die Lottozahlen
            Console.WriteLine("\nAlle Lottozahlen:");
            //string display = "";
            foreach (int zahl in lottozahlen)
            {
                //display += $"\t{zahl.ToString()}";
                Console.WriteLine(zahl);  // Ausgabe: 7 14 23 34 42 50
            }

            //Console.WriteLine(display.TrimStart());

            // Array Länge (Anzahl der Lottozahlen)
            Console.WriteLine("\nAnzahl der Lottozahlen: " + lottozahlen.Length);  // Ausgabe: 6

            // Suchen einer bestimmten Lottozahl (z.B. 34)
            bool enthält34 = Array.Exists(lottozahlen, x => x == 34);
            Console.WriteLine("\nEnthält das Array die Zahl 34? " + enthält34);  // Ausgabe: True

            // Prüfen, ob eine Zahl in den Lottozahlen enthalten ist (z.B. 25)
            bool enthält25 = Array.Exists(lottozahlen, x => x == 25);
            Console.WriteLine("\nEnthält das Array die Zahl 25? " + enthält25);  // Ausgabe: False


        }

        static void ErweitertAutoLottoZahlen()
        {
            int[] Lottozahlen = new int[6];

            Random random = new Random();

            for (int i = 0; i < 6; i++)
            {
                Lottozahlen[i] = random.Next(1, 50);
            }

            Console.WriteLine("Die generierten Lottozahlen sind:");
            foreach (int zahl in Lottozahlen)
            {
                Console.WriteLine(zahl);
            }

            // Überprüfen, ob eine bestimmte Zahl (z.B. 15) in den Lottozahlen enthalten ist
            bool enthält15 = Array.Exists(Lottozahlen, x => x == 15);
            Console.WriteLine("\nEnthält das Array die Zahl 15? " + enthält15);



        }
    
        static void ErweitertAutoLottoZahlenMitVorgabe()
        {
            Console.Write("Bitte gib die Anzahl der Zahlen ein, die generiert werden sollen: ");
            int anzahl = Convert.ToInt32(Console.ReadLine());


            int[] Lottozahlen = new int[anzahl];

            Random random = new Random();

            for (int i = 0; i < Lottozahlen.Length; i++)
            {
                Lottozahlen[i] = random.Next(1, 50);
            }

            Console.WriteLine("Die generierten Lottozahlen sind:");
            foreach (int zahl in Lottozahlen)
            {
                Console.WriteLine(zahl);
            }

            //Schönere Darstellung
            string zahlenOutput = "";
            foreach (int zahl in Lottozahlen)
            {
                zahlenOutput += "\t" + zahl;
            }

            Console.WriteLine("\nSchönere Darstellung:\n" + zahlenOutput.TrimStart());

            // Überprüfen, ob eine bestimmte Zahl (z.B. 15) in den Lottozahlen enthalten ist
            bool enthält = Array.Exists(Lottozahlen, x => x == 15);
            Console.WriteLine("\nEnthält das Array die Zahl 15? " + enthält);
        }
    }
}
