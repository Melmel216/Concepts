﻿namespace Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7 };
            int query = 6;

            Example.Test();
            Sammlungen.FindIndex(numbers, query);


            // Aufgabe: Find Index
            var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
            Console.WriteLine($"FindIndex Test1; Sollte 5; Ist {index}"); // sollte 5 sein
                                                                          // Find Index mit 1.000.000 Elementen in Liste
            var manyNumbers = Sammlungen.GenerateNumbers(1_000_000_000);
            var manyNumbersQuery = 999_999_999;
            Console.WriteLine(manyNumbers.Count);
            var manyNumbersIndex = Sammlungen.FindIndexAlt(manyNumbers, manyNumbersQuery);
            Console.WriteLine($"FindIndex ManyNumbers; Sollte 999_999_999; Ist {manyNumbersIndex}"); // sollte 5 sein



            //Aufgaben Temperature

            //Aufgabe 1:
            Console.WriteLine("Aufgabe Temperature 1:");

            List<int> Gradzahlen = new() { 20, 22, 19, 24, 21, 18, 25 };
            int schwelle = 21;

            List<int> IndexListe = new();

            IndexListe = Temperature.TageÜberSchwelle(Gradzahlen, schwelle);
            
            for (int i = 0; i < IndexListe.Count; i++)
            {
                Console.WriteLine(IndexListe[i]);
            }

            Console.WriteLine("");

            //Aufgabe 2:
            Console.WriteLine("Aufgabe Temperature 2:");

            double ergebnis = Temperature.TemperaturDurchschnitt(Gradzahlen);
            
            Console.WriteLine(ergebnis);

        }


        
    }
}
