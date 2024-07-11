using StaticVSInstance;

int numberInput1 = 0;
int numberInput2 = 0;
int result = 0;

do
{
    Console.Clear();
    Console.WriteLine("Was willst du rechnen?");
    Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide");
    int menuInput = int.Parse(Console.ReadLine());

    numberInput1 = Calculator.GetNumberInput("Gebe die erste Zahl ein:\t");
    numberInput2 = Calculator.GetNumberInput("Gebe die zweite Zahl ein:\t");

    var userSelect = (Operator)menuInput;
    
    switch (userSelect)
    {
        case Operator.Addition:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Addition);
            break;
        case Operator.Subtraction:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Subtraction);
            break;
        case Operator.Multiplication:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Multiplication);
            break;
        case Operator.Division:
            Calculator.Calculate(numberInput1, numberInput2, Operator.Division);
            break;
    }
} while (true);
