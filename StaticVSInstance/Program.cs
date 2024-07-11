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
    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");
    var menuInput = Console.ReadLine();
    switch (menuInput)
    {
        case "1":
            //Calculator.
            // var numberInput1 = Calculator.GetInput();
            Calculator.Calculate(numberInput1, numberInput2, "+");
            //Calculator.BackToMenu();
            break;
        case "2":
            Calculator.Calculate(numberInput1, numberInput2, "-");
            break;
        case"3":
            Calculator.Calculate(numberInput1, numberInput2, "*");
            break;
        case "4":
            Calculator.Calculate(numberInput1, numberInput2, "/");
            break;
    }
} while (true);