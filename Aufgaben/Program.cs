namespace Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7 };
            //int query = 6;

            //Example.Test();
            //Sammlungen.FindIndex(numbers, query);


            //// Aufgabe: Find Index
            /// Optimized Version:
            /// 
            //var index = Sammlungen.FindIndexOptimized(numbers, query);
            //Console.WriteLine($"FindIndexOptimized Test 1; Ist {index}, Sollte 5 sein");


            //var index = Sammlungen.FindIndex(numbers, query); // wenn query 6, sollte index = 5
            //Console.WriteLine($"FindIndex Test1; Sollte 5; Ist {index}"); // sollte 5 sein
            //                                                              // Find Index mit 1.000.000 Elementen in Liste
            //var manyNumbers = Sammlungen.GenerateNumbers(1_000_000_000);
            //var manyNumbersQuery = 999_999_999;
            //Console.WriteLine(manyNumbers.Count);
            //var manyNumbersIndex = Sammlungen.FindIndexAlt(manyNumbers, manyNumbersQuery);
            //Console.WriteLine($"FindIndex ManyNumbers; Sollte 999_999_999; Ist {manyNumbersIndex}"); // sollte 5 sein



            ////Aufgaben Temperature

            ////Aufgabe 1:
            //Console.WriteLine("Aufgabe Temperature 1:");

            //List<int> Gradzahlen = new() { 20, 22, 19, 24, 21, 18, 25 };
            //int schwelle = 21;

            //List<int> IndexListe = new();

            //IndexListe = Temperature.TageÜberSchwelle(Gradzahlen, schwelle);
            
            //for (int i = 0; i < IndexListe.Count; i++)
            //{
            //    Console.WriteLine(IndexListe[i]);
            //}

            //Console.WriteLine("");

            ////Aufgabe 2:
            //Console.WriteLine("Aufgabe Temperature 2:");

            //double ergebnis = Temperature.TemperaturDurchschnitt(Gradzahlen);
            
            //Console.WriteLine(ergebnis);


            //Aufgabe Häufigkeit Zahl in Liste

            List<int> ZahlenListe = new() {1, 2, 2, 3, 4, 4, 4, 5, 6, 6 };

            Console.WriteLine("Aufgabe Häufigkeit Zahl in Liste:");
            Sammlungen.AusgabeHäufigkeit(ZahlenListe);

            //Aufgabe BaumBauer

            Console.WriteLine("Aufgabe Baum:");
            Sammlungen.BaumBauer();

            //Aufgaben Mittwoch:

            //SmallestValue:

            Console.WriteLine("Aufgabe SmallestValue:");
            Console.WriteLine("Sollte sein: 1");
            Console.WriteLine("Ergebnis:");

            int[] numbers = { 5, 6, 8, 12, 34, 2, 1, 7, 9};

            int ergebnis = Sammlungen.FindSmallestValue(numbers);
            Console.WriteLine(ergebnis);



            //Aufgabe OnlyEven:

            Console.WriteLine("Aufgabe OnlyEven:");
            Console.WriteLine("Sollte sein: 6, 8, 12, 34, 2");
            Console.WriteLine("Ergebnis:");

            List<int> OnlyEven = new();

            OnlyEven = Sammlungen.OnlyEven(numbers); //nutzt den  int[] numbers = { 5, 6, 8, 12, 34, 2, 1, 7, 9}; von Aufgabe SmallestValue oben

            foreach (int i in OnlyEven)
            {
                Console.WriteLine(i);
            }

        



        //StringAufgaben:

            Console.WriteLine("String-Aufgaben:\n");

            StringAufgaben.PrintBackwards("Lagerregal");
            StringAufgaben.PrintBackwards("Hamster");





            Console.WriteLine("Wortzählung:\n");
            Console.WriteLine(StringAufgaben.CountWords("Hier könnte Ihre Werbung stehen!"));
            Console.WriteLine(StringAufgaben.CountWords("lorem ipsum dolor est"));


            //CountCharsOfLastWordInText

            Console.WriteLine("String-Aufgabe CountCharsOfLastWordInText:\n");

            int charsOfLastWordCount = StringAufgaben.CountCharsOfLastWordInText("Mein Hamster hat meine Hausis gefressen");
            Console.WriteLine(charsOfLastWordCount);

            int charsOfLastWordCount2 = StringAufgaben.CountCharsOfLastWordInText("Döner mit Scharf");
            Console.WriteLine(charsOfLastWordCount2);

            //Aufgabe PrintConsonantAndVowels
            Console.WriteLine("Aufgabe Konsonanten und Vokale:\n");
            Console.WriteLine("Ergebnis von 'Hallo zusammen! Bald ist Wochenende!'\nsollte sein: Vokale = 11, Konsonanten = 19");
            StringAufgaben.PrintConsonantAndVowels("Hallo zusammen! Bald ist Wochenende!");

            Console.WriteLine("Ergebnis2 von 'H,a: l! l? o!' sollte sein: Vokale = 2, Konsonanten = 3");
            StringAufgaben.PrintConsonantAndVowels("H,a: l! l? o!");
        }





    }
}
