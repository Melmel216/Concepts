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
        public static decimal Count { get; set; }


        // Methoden
        public static decimal GetNumberInput(string inputPrompt)
        {
            Console.Write(inputPrompt);
            return decimal.Parse(Console.ReadLine());
        }

        // Calculate()
        // Refactoring -> Umschreiben vom Code zum Verbessern der Performance, Lesbarkeit oder auch Wartbarkeit
        public static decimal Calculate(decimal numberInput1, decimal numberInput2, Operator op)
        {
            decimal result = 0;
            Count++;
            switch (op)
            {
                case Operator.Addition:
                    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
                    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
                    result = numberInput1 + numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
                    break;
                case Operator.Subtraction:
                    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
                    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
                    result = numberInput1 - numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
                    break;
                case Operator.Multiplication:
                    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
                    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
                    result = numberInput1 * numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
                    break;
                case Operator.Division:
                    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
                    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
                    result = numberInput1 / numberInput2;
                    Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
                    break;
            }

            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return result;
        }

        public static decimal CalculateTriangle()
        {
            //Abfrage Seitenlängen
            Console.WriteLine("Gebe die Länge der Seite a an:");
            decimal sideA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Gebe die Länge der Seite b an:");
            decimal sideB = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Gebe die Länge der Seite c an:");
            decimal sideC = decimal.Parse(Console.ReadLine());

            //Berechne Fläche
            Count++;
            decimal s = (sideA + sideB + sideC) / 2;
            decimal triangleAreaSquared = (s * (s - sideA) * (s - sideB) * (s - sideC));
            decimal triangleArea = (decimal)Math.Sqrt((double)triangleAreaSquared);  //keine Ahnung, wie ohne Sqrt lösen

            Console.WriteLine("Die Fläche des Dreiecks beträgt: " + triangleArea);
            
            //Berechne Umfang
            Count++;
            decimal trianglePerimeter = sideA + sideB + sideC;

            Console.WriteLine("Der Umfang des Dreiecks beträgt: " + trianglePerimeter);
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return triangleArea;
        }

        public static decimal CalculateCircle()
        {
            //Abfrage Durchmesser
            Console.WriteLine("Gebe den Durchmesser des Kreises an:");
            decimal d = decimal.Parse(Console.ReadLine());

            //Berechne Fläche
            Count++;
            decimal radius = d / 2;
            decimal circleArea = (decimal)Math.PI * (radius * radius);
            Console.WriteLine("Die Fläche des Kreises beträgt: " + circleArea);

            //Berechne Umfang
            Count++;
            decimal circlePerimeter = (decimal)Math.PI * d;
            Console.WriteLine("Der Umfang des Kreises beträgt: " + circlePerimeter);
            
            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return circleArea;
        }

        public static decimal CalculateRectangle()
        {
            //Abfrage Seitenlänge
            Console.WriteLine("Gebe die Länge der Seite a an:");
            decimal sideA = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Gebe die Länge der Seite b an:");
            decimal sideB = decimal.Parse(Console.ReadLine());

            //Berechne Fläche
            Count++;
            decimal rectangleArea = sideA * sideB;
            Console.WriteLine("Die Fläche des Rechtecks beträgt: " + rectangleArea);
            
            //Berechne Umfang
            Count++;
            decimal rectanglePerimeter = 2 * (sideA + sideB);
            Console.WriteLine("Der Umfang des Rechtecks beträgt: " + rectanglePerimeter);

            Console.WriteLine($"Du hast {Count} Berechnungen getätigt.");
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            return rectangleArea;
        }
    }

    enum Operator
    {
        Addition = 1,
        Subtraction = 2,
        Multiplication = 3,
        Division = 4,
        Triangle = 5,
        Circle = 6,
        Rectangle = 7
    }

    


    //if (op == "+")
    //{
    //    result = numberInput1 + numberInput2;
    //    Console.WriteLine($"Das Ergebnis von {numberInput1} + {numberInput2} = {result}");
    //}
    //else if (op == "-")
    //{
    //    result = numberInput1 - numberInput2;
    //    Console.WriteLine($"Das Ergebnis von {numberInput1} - {numberInput2} = {result}");
    //}
    //else if (op == "*")
    //{
    //    result = numberInput1 * numberInput2;
    //    Console.WriteLine($"Das Ergebnis von {numberInput1} * {numberInput2} = {result}");
    //}
    //else
    //{
    //    result = numberInput1 / numberInput2;
    //    Console.WriteLine($"Das Ergebnis von {numberInput1} / {numberInput2} = {result}");
    //}



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

    ////eigene Methoden
    //internal static int GetInput(string text)
    //    {
    //        Console.WriteLine(text);
    //        int numberInput = int.Parse(Console.ReadLine());
    //        return numberInput;
    //    }

    //    internal static void ShowMenu()
    //    {
    //        Console.Clear();
    //        Console.WriteLine("Was willst du rechnen?");
    //        Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
    //    }

    //    internal static void BackToMenu()
    //    {
    //        Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
    //        Console.ReadKey();
    //    }


    
}
