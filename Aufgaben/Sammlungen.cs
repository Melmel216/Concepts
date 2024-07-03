using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal static class Sammlungen
    {
        // FindIndex Optimized

        internal static int FindIndexOptimized(List<int> numbers, int query)
        {
            int low = 0;
            int high = numbers.Count - 1;
            int midIndex;
            //int midIndex = (numbers.Count / 2) - 1; //Index der Zahl in der Mitte
            //int midZahl = numbers[midIndex]; //Zahl in der Mitte
            
            while (high >= low)  //(low != high) sieht toll aus, klappt aber nicht wenn Count = gerade Zahl
            {
                midIndex = (high + low) / 2;
                if (numbers[midIndex] == query) 
                  
                    return midIndex;
                
                else if (numbers[midIndex] < query)
                {
                    low = midIndex + 1;
                }
                else
                {
                    high = midIndex - 1;
                }
            }
            return -1;
        }


        /// <summary>
        /// Eine Funktion, welche eine Sammlung und ein gesuchtes Element übergeben bekommt,
        /// und den entsprechenden Index des El ements im Array zurück gibt.
        /// </summary>
        internal static int FindIndex(List<int> numbers, int query)
        {
            // iterieren (durchzählen) durch numbers
            // wenn: numbers[i] == query
            //   return i;
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == query) return i;
            }
            // wenn query nicht gefunden, return -1
            return -1;
        }
        internal static int FindIndexAlt(List<int> numbers, int query)
        {
            // iterieren (durchzählen) durch numbers
            // wenn: numbers[i] == query
            //   return i;
            for (int i = numbers.Count - 1; i > 0; i--)
            {
                if (numbers[i] == query) return i;
            }
            // wenn query nicht gefunden, return -1
            return -1;
        }

        internal static List<int> GenerateNumbers(int amount)
        {
            List<int> numbers = new();
            for (int i = 0; i < amount; i++)
                numbers.Add(i);
            return numbers;
        }


        /// <summary>
        /// Eine Funktion, welche eine Liste mit Integers bekommt, und in der Konsole 
        /// die Häufigkeit jedes Elements druckt.
        /// Beispiel
        /// Input: [1,2,3,3,5,2,-10,-10]
        /// Output: 
        /// Zahl 1: 1
        /// Zahl 2: 2
        /// Zahl 3: 2
        /// Zahl 5: 1
        /// Zahl -10: 2
        /// 
        /// </summary>
        internal static void AusgabeHäufigkeit(List<int> ZahlenListe)
        {
            List<int> ErgebnisListe = new();

            
            foreach (int zahl in ZahlenListe)
            {
                bool nichtenthalten = true;
                int häufigkeit = 0;

                for (int j = 0;j < ErgebnisListe.Count; j++)
                {
                    if (zahl == ErgebnisListe[j])
                    {
                        nichtenthalten = false;
                        break;
                    }
                }
                if(nichtenthalten)
                {
                    for (int i = 0; i < ZahlenListe.Count; i++)
                    {
                        if (zahl == ZahlenListe[i])
                        {
                            häufigkeit = häufigkeit + 1;
                        }
                    }
                    ErgebnisListe.Add(zahl);
                    Console.WriteLine($"Zahl {zahl}: {häufigkeit}");
                }
            }
        }
            //Fehlversuch: foreach(int zahl in ZahlenListe)
            //{
            //    int häufigkeit = 0;
            //    bool nichtenthalten = true;
            //    for (int i = 0; i < ZahlenListe.Count; i++)
            //    {
            //        for(int j = 0; j < ErgebnisListe.Count; j++)
            //        {
            //            if (zahl == ErgebnisListe[j])
            //            {
            //                nichtenthalten = false;
            //            }
            //        if (nichtenthalten)
            //            {
            //                if (zahl == ZahlenListe[i])
            //                {
            //                    häufigkeit = häufigkeit + 1;
            //                }
            //            }
            //        }
            //    }
            //ErgebnisListe.Add(zahl);
            //Console.WriteLine($"Zahl {zahl}: {häufigkeit}");

            //}
       
        
        /// <summary>
        /// Eine Funktion, welche einen Weihnachtsbaum in der Konsole druckt. 
        /// Input: wie gewünscht (eventuell Höhe des Baums)
        /// Output (Console.WriteLine()): 
        ///    #
        ///   ###
        ///  #####
        /// #######
        ///    #
        /// </summary>
        internal static void BaumBauer()
        {
            Console.WriteLine("    #");
            Console.WriteLine("   ###");
            Console.WriteLine("  #####");
            Console.WriteLine(" #######");
            Console.WriteLine("    #");
        }
    }
}

