using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_List_selbständigeÜbung_fürSchnelle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Willkommen zur erweiterten Film-Verwaltung!");

            // **Teil 1: Arbeiten mit einem Array (Filmbewertungen)**
            Console.WriteLine("\nWie viele Filme möchten Sie bewerten?");
            int anzahlFilme = int.Parse(Console.ReadLine());
            int[] bewertungen = new int[anzahlFilme];

            Console.WriteLine("\nGeben Sie die Bewertungen ein (Zahlen von 1 bis 10):");
            for (int i = 0; i < bewertungen.Length; i++)
            {
                Console.Write($"Bewertung für Film {i + 1}: ");
                bewertungen[i] = int.Parse(Console.ReadLine());
            }

            // Durchschnitt, höchste und niedrigste Bewertung berechnen
            double durchschnitt = 0;
            int höchste = bewertungen[0], niedrigste = bewertungen[0];
            foreach (int bewertung in bewertungen)
            {
                durchschnitt += bewertung;
                if (bewertung > höchste) höchste = bewertung;
                if (bewertung < niedrigste) niedrigste = bewertung;
            }
            durchschnitt /= bewertungen.Length;

            Console.WriteLine($"\nDurchschnittliche Bewertung: {durchschnitt:F2}");
            Console.WriteLine($"Höchste Bewertung: {höchste}");
            Console.WriteLine($"Niedrigste Bewertung: {niedrigste}");

            // **Bewertungen erweitern**
            Console.WriteLine("\nMöchten Sie eine Bewertung hinzufügen oder ändern? (Ja/Nein)");
            string bewertungAntwort = Console.ReadLine().ToLower();
            if (bewertungAntwort == "ja")
            {
                Console.WriteLine("1. Bewertung hinzufügen\n2. Bewertung ändern");
                int auswahl = int.Parse(Console.ReadLine());

                if (auswahl == 1)
                {
                    Array.Resize(ref bewertungen, bewertungen.Length + 1);
                    Console.Write($"Neue Bewertung für Film {bewertungen.Length}: ");
                    bewertungen[bewertungen.Length - 1] = int.Parse(Console.ReadLine());
                }
                else if (auswahl == 2)
                {
                    Console.Write("Welche Bewertung möchten Sie ändern (Index 1 bis n)? ");
                    int index = int.Parse(Console.ReadLine()) - 1;
                    if (index >= 0 && index < bewertungen.Length)
                    {
                        Console.Write("Neue Bewertung: ");
                        bewertungen[index] = int.Parse(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("Ungültiger Index.");
                    }
                }
            }

            // **Teil 2: Arbeiten mit einer Liste (Filmtitel)**
            Console.WriteLine("\nWie viele Filme möchten Sie speichern?");
            int anzahlTitel = int.Parse(Console.ReadLine());
            List<string> filme = new List<string>();

            Console.WriteLine("\nGeben Sie die Titel ein:");
            for (int i = 0; i < anzahlTitel; i++)
            {
                Console.Write($"Titel für Film {i + 1}: ");
                filme.Add(Console.ReadLine());
            }

            // **Liste erweitern**
            Console.WriteLine("\nMöchten Sie neue Filme hinzufügen? (Ja/Nein)");
            string titelAntwort = Console.ReadLine().ToLower();
            if (titelAntwort == "ja")
            {
                Console.WriteLine("Wie viele Filme möchten Sie hinzufügen?");
                int neueFilme = int.Parse(Console.ReadLine());
                for (int i = 0; i < neueFilme; i++)
                {
                    Console.Write($"Neuer Titel {i + 1}: ");
                    filme.Add(Console.ReadLine());
                }
            }

            // Film suchen
            Console.WriteLine("\nMöchten Sie prüfen, ob ein bestimmter Film in der Liste ist? (Ja/Nein)");
            string suchAntwort = Console.ReadLine().ToLower();
            if (suchAntwort == "ja")
            {
                Console.Write("Geben Sie den Titel des Films ein: ");
                string suchFilm = Console.ReadLine();
                Console.WriteLine(filme.Contains(suchFilm)
                    ? $"Der Film '{suchFilm}' ist in der Liste enthalten."
                    : $"Der Film '{suchFilm}' ist nicht in der Liste.");
            }

            // Liste sortieren und ausgeben
            filme.Sort();
            Console.WriteLine("\nFilme in alphabetischer Reihenfolge:");
            foreach (string film in filme)
            {
                Console.WriteLine(film);
            }

            Console.WriteLine($"\nAnzahl der Filme: {filme.Count}");
            Console.WriteLine("Vielen Dank fürs Mitmachen!");

            Console.ReadLine();
        }
    }
}
