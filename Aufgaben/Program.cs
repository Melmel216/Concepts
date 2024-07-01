namespace Aufgaben
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new() { 1, 2, 3, 4, 5, 6, 7 };
            int query = 6;

            Example.Test();
            Sammlungen.FindIndex(numbers, query);
                       

            //Aufgabe: Find Index
            var index = Sammlungen.FindIndex(numbers, query); //wenn query 6, sollte 
            //Index gleich 5 sein
            Console.WriteLine(index);


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
