using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ListDemonstration_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            BenutzerverwaltungErweitertNamensSuche();
            Console.ReadLine();
        }

        static void Basic()
        {
            // Liste von Benutzern erstellen
            List<string> benutzerListe = new List<string>();

            // Benutzer hinzufügen
            benutzerListe.Add("Sarah");
            benutzerListe.Add("Max");
            benutzerListe.Add("Anna");

            // Ausgabe der Benutzerliste
            Console.WriteLine("Benutzer in der Liste:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer entfernen
            benutzerListe.Remove("Max");
            Console.WriteLine("\nMax wurde entfernt. Neue Benutzerliste:");

            // Ausgabe der Liste nach Entfernen eines Benutzers
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer suchen
            bool enthältSarah = benutzerListe.Contains("Sarah");
            Console.WriteLine("\nEnthält die Liste den Benutzer 'Sarah'? " + enthältSarah);  // Ausgabe: True

            // Anzahl der Benutzer in der Liste
            Console.WriteLine("\nAnzahl der Benutzer: " + benutzerListe.Count);  // Ausgabe: 2

            // Benutzerliste sortieren
            benutzerListe.Sort();
            Console.WriteLine("\nBenutzerliste nach dem Sortieren:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }
        }

        static void BenutzerverwaltungErweitertIndexSuche()
        {
            // Liste von Benutzern erstellen
            List<string> benutzerListe = new List<string>();

            // Benutzer hinzufügen
            benutzerListe.Add("Sarah");
            benutzerListe.Add("Max");
            benutzerListe.Add("Anna");

            // Ausgabe der Benutzerliste
            Console.WriteLine("Benutzer in der Liste:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer entfernen
            benutzerListe.Remove("Max");
            Console.WriteLine("\nMax wurde entfernt. Neue Benutzerliste:");

            // Ausgabe der Liste nach Entfernen eines Benutzers
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer suchen
            bool enthältSarah = benutzerListe.Contains("Sarah");
            Console.WriteLine("\nEnthält die Liste den Benutzer 'Sarah'? " + enthältSarah);  // Ausgabe: True

            // Anzahl der Benutzer in der Liste
            Console.WriteLine("\nAnzahl der Benutzer: " + benutzerListe.Count);  // Ausgabe: 2

            // Benutzerliste sortieren
            benutzerListe.Sort();
            Console.WriteLine("\nBenutzerliste nach dem Sortieren:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            //Benutzer bei bestimmten Index ausgeben
            Console.Write("\nWelchen Benutzer (über index: startet bei 0) möchtest du ausgeben: ");
            int benutzerBeiIndex = Convert.ToInt32(Console.ReadLine());

            if (benutzerBeiIndex < benutzerListe.Count)
            {
                string benutzer = benutzerListe.ElementAt(benutzerBeiIndex);
                Console.WriteLine("\nBenutzer bei Index " + benutzerBeiIndex + " ist " + benutzer);
            }
            else
            {
                Console.WriteLine("Die Liste enthält weniger Benutzer als der angegeben index");
            }
        }

        static void BenutzerverwaltungErweitertNamensSuche()
        {
            // Liste von Benutzern erstellen
            List<string> benutzerListe = new List<string>();

            // Benutzer hinzufügen
            benutzerListe.Add("Sarah Weber");
            benutzerListe.Add("Max Mustermann");
            benutzerListe.Add("Anna Webermeister");

            // Ausgabe der Benutzerliste
            Console.WriteLine("Benutzer in der Liste:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer entfernen
            benutzerListe.Remove("Max");
            Console.WriteLine("\nMax wurde entfernt. Neue Benutzerliste:");

            // Ausgabe der Liste nach Entfernen eines Benutzers
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            // Benutzer suchen
            bool enthältSarah = benutzerListe.Contains("Sarah");
            Console.WriteLine("\nEnthält die Liste den Benutzer 'Sarah'? " + enthältSarah);  // Ausgabe: True

            // Anzahl der Benutzer in der Liste
            Console.WriteLine("\nAnzahl der Benutzer: " + benutzerListe.Count);  // Ausgabe: 2

            // Benutzerliste sortieren
            benutzerListe.Sort();
            Console.WriteLine("\nBenutzerliste nach dem Sortieren:");
            foreach (string benutzer in benutzerListe)
            {
                Console.WriteLine(benutzer);
            }

            //Benutzer bei bestimmten Index ausgeben
            Console.Write("\nWelchen Benutzer (über index: startet bei 0) möchtest du ausgeben: ");
            int benutzerBeiIndex = Convert.ToInt32(Console.ReadLine());

            if (benutzerBeiIndex < benutzerListe.Count)
            {
                string benutzer = benutzerListe.ElementAt(benutzerBeiIndex);
                Console.WriteLine("\nBenutzer bei Index " + benutzerBeiIndex + " ist " + benutzer);
            }
            else
            {
                Console.WriteLine("Die Liste enthält weniger Benutzer als der angegeben index");
            }

            // Benutzer nach einem Namen fragen
            Console.WriteLine("\nBitte geben Sie einen Namen ein, den Sie suchen möchten:");
            string suchName = Console.ReadLine();

            // Namenssuche durchführen
            List<string> gefundeneBenutzer = new List<string>();

            foreach(string benutzer in benutzerListe)
            {
                if(benutzer.IndexOf(suchName, StringComparison.OrdinalIgnoreCase) >= 0)
                {
                    gefundeneBenutzer.Add(benutzer);
                }
            }



            // Ergebnisse ausgeben
            if (gefundeneBenutzer.Count > 0)
            {
                Console.WriteLine("\nGefundene Teilnehmer:");
                foreach (string teilnehmer in gefundeneBenutzer)
                {
                    Console.WriteLine(teilnehmer);
                }
            }
            else
            {
                Console.WriteLine("\nKeine Teilnehmer gefunden, die den Namen enthalten.");
            }
        }

    }
}
