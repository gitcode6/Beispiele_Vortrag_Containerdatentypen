using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemonstration_B1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ErweiterungDynamischeProdukte();
            Console.ReadLine();
        }

        static void Basic()
        {
            // Erstelle eine ArrayList mit verschiedenen Typen
            ArrayList einkaufsListe = new ArrayList();

            // Füge verschiedene Datentypen hinzu
            einkaufsListe.Add("Äpfel");      // string
            einkaufsListe.Add(1);            // int (Anzahl der Äpfel)
            einkaufsListe.Add(2.99);         // double (Preis pro Apfel)

            einkaufsListe.Add("Bananen");    // string
            einkaufsListe.Add(2);            // int (Anzahl der Bananen)
            einkaufsListe.Add(1.49);         // double (Preis pro Banane)

            einkaufsListe.Add("Kirschen");   // string
            einkaufsListe.Add(1);            // int (Anzahl der Kirschen)
            einkaufsListe.Add(3.50);         // double (Preis pro Kirsche)

            // Artikel und ihre Preise ausgeben
            Console.WriteLine("Einkaufsartikel und Preise:");
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                string artikel = (string)einkaufsListe[i];  // Artikelname
                int anzahl = (int)einkaufsListe[i + 1];     // Anzahl
                double preis = (double)einkaufsListe[i + 2]; // Preis pro Artikel

                Console.WriteLine($"{artikel} - Anzahl: {anzahl}, Preis pro Stück: {preis:F2} €");
            }

            // Gesamtkosten berechnen
            double gesamtpreis = 0;
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                double preis = (double)einkaufsListe[i + 2];
                int anzahl = (int)einkaufsListe[i + 1];
                gesamtpreis += preis * anzahl;
            }

            Console.WriteLine($"\nGesamtkosten: {gesamtpreis:F2} €");

            // Suche nach einem bestimmten Artikel
            Console.WriteLine("\nGeben Sie einen Artikel ein, nach dem Sie suchen möchten:");
            string suchArtikel = Console.ReadLine();

            // Suche nach dem Artikel in der Liste
            bool gefunden = false;
            string[] detailsGefunden = new string[3];
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                string artikel = (string)einkaufsListe[i]; // Artikelname
                if (artikel.Equals(suchArtikel, StringComparison.OrdinalIgnoreCase)) // Vergleiche ohne Groß-/Kleinschreibung
                {
                    gefunden = true;
                    detailsGefunden[0] = artikel;
                    detailsGefunden[1] = einkaufsListe[i + 1].ToString();
                    detailsGefunden[2] = einkaufsListe[i + 2].ToString();
                    break;
                }
            }

            if (gefunden)
            {
                Console.WriteLine($"Der Artikel '{suchArtikel}' wurde gefunden!\n{detailsGefunden[0]} kommt {detailsGefunden[1]}-mal auf der Einkaufsliste vor (Stückpreis: {detailsGefunden[2]})");
            }
            else
            {
                Console.WriteLine($"Der Artikel '{suchArtikel}' wurde nicht gefunden.");
            }
        }

        static void ErweiterungDynamischeProdukte()
        {
            // Erstelle eine ArrayList mit verschiedenen Typen
            ArrayList einkaufsListe = new ArrayList();

            // Füge verschiedene Datentypen hinzu
            einkaufsListe.Add("Äpfel");      // string
            einkaufsListe.Add(1);            // int (Anzahl der Äpfel)
            einkaufsListe.Add(2.99);         // double (Preis pro Apfel)

            Console.Write("Geben Sie die Anzahl der Produkte ein: ");
            int produktetGesamt = Convert.ToInt32(Console.ReadLine());

            for(int i=0; i < produktetGesamt; i++)
            {
                Console.Write($"Gib den Namen von Produkt { i + 1} ein: ");
                int pIndex = einkaufsListe.Add(Console.ReadLine());

                Console.Write("Gib die Menge von Produkt '" + einkaufsListe[pIndex] + "' ein: ");
                einkaufsListe.Add(Convert.ToInt32(Console.ReadLine()));

                Console.Write("Gib den Stückpreis von Produkt " + einkaufsListe[pIndex] + " ein: ");
                einkaufsListe.Add(Convert.ToDouble(Console.ReadLine()));
            }

            // Artikel und ihre Preise ausgeben
            Console.WriteLine("Einkaufsartikel und Preise:");
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                string artikel = (string)einkaufsListe[i];  // Artikelname
                int anzahl = (int)einkaufsListe[i + 1];     // Anzahl
                double preis = (double)einkaufsListe[i + 2]; // Preis pro Artikel

                Console.WriteLine($"{artikel} - Anzahl: {anzahl}, Preis pro Stück: {preis:F2} Euro");
            }

            // Gesamtkosten berechnen
            double gesamtpreis = 0;
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                double preis = (double)einkaufsListe[i + 2];
                int anzahl = (int)einkaufsListe[i + 1];
                gesamtpreis += preis * anzahl;
            }

            Console.WriteLine($"\nGesamtkosten: {gesamtpreis:F2} Euro");

            // Suche nach einem bestimmten Artikel
            Console.WriteLine("\nGeben Sie einen Artikel ein, nach dem Sie suchen möchten:");
            string suchArtikel = Console.ReadLine();

            // Suche nach dem Artikel in der Liste
            bool gefunden = false;
            string[] detailsGefunden = new string[3];
            for (int i = 0; i < einkaufsListe.Count; i += 3)
            {
                string artikel = (string)einkaufsListe[i]; // Artikelname
                if (artikel.Equals(suchArtikel, StringComparison.OrdinalIgnoreCase)) // Vergleiche ohne Groß-/Kleinschreibung
                {
                    gefunden = true;
                    detailsGefunden[0] = artikel;
                    detailsGefunden[1] = einkaufsListe[i + 1].ToString();
                    detailsGefunden[2] = einkaufsListe[i + 2].ToString();
                    break;
                }
            }

            if (gefunden)
            {
                Console.WriteLine($"Der Artikel '{suchArtikel}' wurde gefunden!\n{detailsGefunden[0]} kommt {detailsGefunden[1]}-mal auf der Einkaufsliste vor (Stückpreis: {detailsGefunden[2]})");
            }
            else
            {
                Console.WriteLine($"Der Artikel '{suchArtikel}' wurde nicht gefunden.");
            }
        }
    }
}
