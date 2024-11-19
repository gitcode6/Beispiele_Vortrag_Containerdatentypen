using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Dictionary_selbständigeÜbung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dictionary für die Kontaktliste
            Dictionary<string, string> kontakte = new Dictionary<string, string>();

            while (true)
            {
                Console.WriteLine("\nWas möchten Sie tun?");
                Console.WriteLine("1 - Neuen Kontakt hinzufügen");
                Console.WriteLine("2 - Alle Kontakte anzeigen");
                Console.WriteLine("3 - Kontakt suchen");
                Console.WriteLine("4 - Kontakt löschen");
                Console.WriteLine("5 - Programm beenden");
                Console.Write("Bitte wählen Sie eine Option (1-5): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Neuen Kontakt hinzufügen
                        Console.Write("\nGeben Sie den Namen des Kontakts ein: ");
                        string name = Console.ReadLine();

                        // Prüfen, ob der Kontakt bereits existiert
                        if (kontakte.ContainsKey(name))
                        {
                            Console.WriteLine("Dieser Kontakt existiert bereits.");
                        }
                        else
                        {
                            Console.Write("Geben Sie die Telefonnummer des Kontakts ein: ");
                            string telefonnummer = Console.ReadLine();
                            kontakte.Add(name, telefonnummer);
                            Console.WriteLine($"Kontakt '{name}' wurde hinzugefügt.");
                        }
                        break;

                    case "2":
                        // Alle Kontakte anzeigen
                        Console.WriteLine("\nAlle Kontakte:");
                        foreach (var kontakt in kontakte)
                        {
                            Console.WriteLine($"Name: {kontakt.Key}, Telefonnummer: {kontakt.Value}");
                        }
                        break;

                    case "3":
                        // Kontakt suchen
                        Console.Write("\nGeben Sie den Namen des Kontakts ein, den Sie suchen möchten: ");
                        string suchName = Console.ReadLine();

                        if (kontakte.ContainsKey(suchName))
                        {
                            Console.WriteLine($"Kontakt gefunden: Name: {suchName}, Telefonnummer: {kontakte[suchName]}");
                        }
                        else
                        {
                            Console.WriteLine($"Kein Kontakt mit dem Namen '{suchName}' gefunden.");
                        }
                        break;

                    case "4":
                        // Kontakt löschen
                        Console.Write("\nGeben Sie den Namen des Kontakts ein, den Sie löschen möchten: ");
                        string loeschName = Console.ReadLine();

                        if (kontakte.ContainsKey(loeschName))
                        {
                            kontakte.Remove(loeschName);
                            Console.WriteLine($"Kontakt '{loeschName}' wurde gelöscht.");
                        }
                        else
                        {
                            Console.WriteLine($"Kein Kontakt mit dem Namen '{loeschName}' gefunden.");
                        }
                        break;

                    case "5":
                        // Programm beenden
                        Console.WriteLine("Programm wird beendet.");
                        return;

                    default:
                        Console.WriteLine("Ungültige Auswahl, bitte versuchen Sie es erneut.");
                        break;
                }
            }
        }
    }
}
