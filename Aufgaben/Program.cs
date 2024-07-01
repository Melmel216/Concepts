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
        }
    }
}
