using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticVSInstance
{
    internal class Calculator
    {
        //Keine Properties
        // Properties
        // public string Title { get; set; }
        // public int InstanceCount { get; set; }
        public static int Count { get; set; }


        // Methoden
        public static int GetNumberInput(string inputPrompt)
        {
            Console.Write(inputPrompt);
            return int.Parse(Console.ReadLine());
        }

        // Calculate()
        // Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit
        public static int Calculate(int numberInput1, int numberInput2, string op)
        {
            int result = 0;
            Count++;
            if (op == "+")
            {
                result = numberInput1 + numberInput2;
                Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
            }
            else if (op == "-")
            {
                result = numberInput1 - numberInput2;
                Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
            }
            else if (op == "*")
            {
                result = numberInput1 * numberInput2;
                Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
            }
            else
            {
                result = numberInput1 / numberInput2;
                Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
            }

            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        internal enum Operation
        {
            Add = 1,
            Subtract = 2,
            Multiply = 3,
            Divide = 4
        }





        //public static int Add(int numberInput1, int numberInput2)
        //{
        //    Count++;
        //    var result = numberInput1 + numberInput2;
        //    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
        //    Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
        //    return result;
        //}

        //public static int Subtract(int numberInput1, int numberInput2)
        //{
        //    Count++;
        //    var result = numberInput1 - numberInput2;
        //    Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
        //    Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
        //    return result;
        //}

        //public static int Multiply(int numberInput1, int numberInput2)
        //{
        //    Count++;
        //    var result = numberInput1 * numberInput2;
        //    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
        //    Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
        //    return result;
        //}

        //public static int Divide(int numberInput1, int numberInput2)
        //{
        //    Count++;
        //    var result = numberInput1 / numberInput2;
        //    Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
        //    Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
        //    return result;
        //}

        /// <summary>
        /// Das hier ist wie Add(), aber wird über die Instanz der Klasse (konkretes Objekt eg. "calc1.AddInstance") aufgerufen. Der InstanceCount ist für jede Instanz (Objekt) unterschiedlich (eg. calc1.InstanceCount != calc2.InstanceCount)
        /// </summary>
        /// <param name="numberInput1"></param>
        /// <param name="numberInput2"></param>
        /// <returns></returns>
        /*
        public int AddInstance(int numberInput1, int numberInput2)
        {
          InstanceCount++;
          var result = numberInput1 + numberInput2;
          Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
          return result;
        }
        */

        //eigene Methoden
        internal static int GetInput(string text)
        {
            Console.WriteLine(text);
            int numberInput = int.Parse(Console.ReadLine());
            return numberInput;
        }

        internal static void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Was willst du rechnen?");
            Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
        }

        internal static void BackToMenu()
        {
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
        }


    }
}
