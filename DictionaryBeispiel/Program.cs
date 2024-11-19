using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryBeispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Erstelle ein Dictionary, das Benutzernamen (Schlüssel) mit Alter (Wert) verknüpft
            Dictionary<string, int> benutzerDaten = new Dictionary<string, int>();

            // Füge einige Benutzer mit Alter hinzu
            benutzerDaten.Add("Anna", 25);
            benutzerDaten.Add("Max", 30);
            benutzerDaten.Add("Lisa", 28);

            while (true)
            {
                Console.WriteLine("\nWas möchten Sie tun?");
                Console.WriteLine("1 - Benutzer hinzufügen");
                Console.WriteLine("2 - Alter eines Benutzers anzeigen");
                Console.WriteLine("3 - Alle Benutzer anzeigen");
                Console.WriteLine("4 - Alter eines Benutzers ändern");
                Console.WriteLine("5 - Nach einem Benutzer suchen");
                Console.WriteLine("6 - Einen Benutzer löschen");
                Console.WriteLine("7 - Programm beenden");
                Console.Write("Bitte wählen Sie eine Option (1-6): ");
                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        // Benutzer hinzufügen
                        Console.WriteLine("\nGeben Sie den Benutzernamen ein:");
                        string neuerBenutzer = Console.ReadLine();

                        Console.WriteLine("Geben Sie das Alter des Benutzers ein:");
                        int alter = int.Parse(Console.ReadLine());

                        // Füge den Benutzer und sein Alter zum Dictionary hinzu
                        benutzerDaten[neuerBenutzer] = alter;

                        Console.WriteLine($"Benutzer '{neuerBenutzer}' wurde hinzugefügt.");
                        break;

                    case "2":
                        // Alter eines Benutzers anzeigen
                        Console.WriteLine("\nGeben Sie den Benutzernamen ein, dessen Alter Sie anzeigen möchten:");
                        string benutzerName = Console.ReadLine();

                        if (benutzerDaten.ContainsKey(benutzerName))
                        {
                            Console.WriteLine($"{benutzerName} ist {benutzerDaten[benutzerName]} Jahre alt.");
                        }
                        else
                        {
                            Console.WriteLine($"Benutzer '{benutzerName}' wurde nicht gefunden.");
                        }
                        break;

                    case "3":
                        // Alle Benutzer anzeigen
                        Console.WriteLine("\nAlle Benutzer und ihr Alter:");
                        foreach (var benutzer in benutzerDaten)
                        {
                            Console.WriteLine($"{benutzer.Key} - {benutzer.Value} Jahre alt");
                        }
                        break;

                    case "4":
                        // Alter eines Benutzers ändern
                        Console.WriteLine("\nGeben Sie den Benutzernamen ein, dessen Alter Sie ändern möchten:");
                        string benutzerZumAendern = Console.ReadLine();

                        if (benutzerDaten.ContainsKey(benutzerZumAendern))
                        {
                            Console.WriteLine("Geben Sie das neue Alter ein:");
                            int neuesAlter = int.Parse(Console.ReadLine());

                            benutzerDaten[benutzerZumAendern] = neuesAlter;

                            Console.WriteLine($"Das Alter von {benutzerZumAendern} wurde auf {neuesAlter} geändert.");
                        }
                        else
                        {
                            Console.WriteLine($"Benutzer '{benutzerZumAendern}' wurde nicht gefunden.");
                        }
                        break;

                    case "5":
                        // Nach einem Benutzer suchen
                        Console.WriteLine("\nGeben Sie den Benutzernamen ein, nach dem Sie suchen möchten:");
                        string suchBenutzer = Console.ReadLine();

                        if (benutzerDaten.ContainsKey(suchBenutzer))
                        {
                            Console.WriteLine($"Benutzer '{suchBenutzer}' wurde gefunden, er ist {benutzerDaten[suchBenutzer]} Jahre alt.");
                        }
                        else
                        {
                            Console.WriteLine($"Benutzer '{suchBenutzer}' wurde nicht gefunden.");
                        }
                        break;


                    case "6":
                        Console.WriteLine("\nGeben Sie den Benutzernamen ein, den Sie löschen möchten:");
                        string löschBenutzer = Console.ReadLine();

                        if (benutzerDaten.ContainsKey(löschBenutzer))
                        {
                            benutzerDaten.Remove(löschBenutzer);
                            Console.WriteLine($"Benutzer '{löschBenutzer}' wurde gefunden, er wurde erfolgreich gelöscht.");
                        }
                        else
                        {
                            Console.WriteLine($"Benutzer '{löschBenutzer}' wurde nicht gefunden.");
                        }
                        break;

                    case "7":
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
