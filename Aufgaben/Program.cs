﻿namespace Aufgaben
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

            //    List<int> ZahlenListe = new() {1, 2, 2, 3, 4, 4, 4, 5, 6, 6 };

            //    Console.WriteLine("Aufgabe Häufigkeit Zahl in Liste:");
            //    Sammlungen.AusgabeHäufigkeit(ZahlenListe);

            //    //Aufgabe BaumBauer

            //    Console.WriteLine("Aufgabe Baum:");
            //    Sammlungen.BaumBauer();

            //    //Aufgaben Mittwoch:

            //    //SmallestValue:

            //    Console.WriteLine("Aufgabe SmallestValue:");
            //    Console.WriteLine("Sollte sein: 1");
            //    Console.WriteLine("Ergebnis:");

            //    int[] numbers = { 5, 6, 8, 12, 34, 2, 1, 7, 9};

            //    int ergebnis = Sammlungen.FindSmallestValue(numbers);
            //    Console.WriteLine(ergebnis);



            //    //Aufgabe OnlyEven:

            //    Console.WriteLine("Aufgabe OnlyEven:");
            //    Console.WriteLine("Sollte sein: 6, 8, 12, 34, 2");
            //    Console.WriteLine("Ergebnis:");

            //    List<int> OnlyEven = new();

            //    OnlyEven = Sammlungen.OnlyEven(numbers); //nutzt den  int[] numbers = { 5, 6, 8, 12, 34, 2, 1, 7, 9}; von Aufgabe SmallestValue oben

            //    foreach (int i in OnlyEven)
            //    {
            //        Console.WriteLine(i);
            //    }





            ////StringAufgaben:

            //    Console.WriteLine("String-Aufgaben:\n");

            //    StringAufgaben.PrintBackwards("Lagerregal");
            //    StringAufgaben.PrintBackwards("Hamster");





            //    Console.WriteLine("Wortzählung:\n");
            //    Console.WriteLine(StringAufgaben.CountWords("Hier könnte Ihre Werbung stehen!"));
            //    Console.WriteLine(StringAufgaben.CountWords("lorem ipsum dolor est"));


            //    //CountCharsOfLastWordInText

            //    Console.WriteLine("String-Aufgabe CountCharsOfLastWordInText:\n");

            //    int charsOfLastWordCount = StringAufgaben.CountCharsOfLastWordInText("Mein Hamster hat meine Hausis gefressen");
            //    Console.WriteLine(charsOfLastWordCount);

            //    int charsOfLastWordCount2 = StringAufgaben.CountCharsOfLastWordInText("Döner mit Scharf");
            //    Console.WriteLine(charsOfLastWordCount2);

            //    //Aufgabe PrintConsonantAndVowels
            //    Console.WriteLine("Aufgabe Konsonanten und Vokale:\n");
            //    Console.WriteLine("Ergebnis von 'Hallo zusammen!'\nsollte sein: Vokale = 5, Konsonanten = 8");
            //    StringAufgaben.PrintConsonantAndVowels("Hallo zusammen!");

            //    Console.WriteLine("Ergebnis2 von 'H,a: l! l? o!' sollte sein: Vokale = 2, Konsonanten = 3");
            //    StringAufgaben.PrintConsonantAndVowels("H,a: l! l? o!");

            //    Console.WriteLine();

            //    //Aufgabe ContainsDuplicates aus Sammlungen
            //    Console.WriteLine("Aufgabe ContainsDuplicates:\n");
            //    int[] duplicateTest1 = { 0, 1, 2, 3};
            //    int[] duplicateTest2 = { 0, 1, 1, 2, 3, 4};

            //    Console.WriteLine("Test1, Ergebnis sollte 'false' sein:");
            //    Console.WriteLine(Sammlungen.ContainsDuplicates(duplicateTest1));
            //    Console.WriteLine("Test2, Ergebnis sollte 'true' sein:");
            //    Console.WriteLine(Sammlungen.ContainsDuplicates(duplicateTest2));

            //    Console.WriteLine("Aufgabe DiamondBauer:\n");
            //    Sammlungen.DiamondBauer(4);
            //}


            //// KlassenAufgaben
            
            ////Book-Aufgabe

            ////Instanzen erstellen:

            //Book book1 = new Book("Storm Front", "Jim Butcher", 2000, "9783867621113");
            //Book book2 = new Book("Fool Moon", "Jim Butcher", 2000, "9783867621120");
            //Book book3 = new Book("Grave Peril", "Jim Butcher", 2001, "9783867621137");

            ////Aufruf der Methode GetDescription + Ausgabe in der Konsole 
            //Console.WriteLine(book1.GetDescription());
            //Console.WriteLine(book2.GetDescription());
            //Console.WriteLine(book3.GetDescription());


            //Console.WriteLine();

            ////Aufgabe Car

            ////Instanzen erstellen:

            //Car car1 = new Car("Ford", "Mustang", 2018, 23000);
            //Car car2 = new Car("Toyota", "Corolla", 2015, 45000);
            //Car car3 = new Car("BMW", "X5", 2019, 32000);

            ////Aufruf der Methoden + Ausgabe in der Konsole:

            //int drivenKm = 2000;
            ////Car1
            //Console.WriteLine(car1.GetDescription());
            //Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car1.Drive(drivenKm) + "km");
            //Console.WriteLine("Das Auto ist " + car1.Age() + " Jahre alt.\n");

            ////Car2
            //Console.WriteLine(car2.GetDescription());
            //Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car2.Drive(drivenKm) + "km");
            //Console.WriteLine("Das Auto ist " + car2.Age() + " Jahre alt.\n");
            
            ////Car3
            //Console.WriteLine(car3.GetDescription());
            //Console.WriteLine("Nach " + drivenKm + " weiteren gefahrenen Kilometern\nbeträgt der neue Kilometerstand: " + car3.Drive(drivenKm) + "km");
            //Console.WriteLine("Das Auto ist " + car3.Age() + " Jahre alt.\n");
        }

    }
}
