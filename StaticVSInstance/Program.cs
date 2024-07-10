using StaticVSInstance;

int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;

do
{
    //Console.Clear();
    //Console.WriteLine("Was willst du rechnen?");
    //Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
    Calculator.ShowMenu();
    var menuInput = Console.ReadLine();
    switch (menuInput)
    {
        case "1":
            //Calculator.
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
            // var numberInput1 = Calculator.GetInput();
            Calculator.Add(numberInput1, numberInput2);
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            //Calculator.BackToMenu();
            break;
        case "2":
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
            Calculator.Subtract(numberInput1, numberInput2);
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            break;
        case"3":
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
            Calculator.Multiply(numberInput1, numberInput2); 
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            break;
        case "4":
            numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
            numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
            result = numberInput1 / numberInput2;
            Calculator.Divide(numberInput1, numberInput2);
            Console.WriteLine("Drücke irgendwas für eine neue Berechnung");
            Console.ReadKey();
            break;
    }
} while (true);