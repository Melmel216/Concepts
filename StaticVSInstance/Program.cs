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
    
    switch (menuInput)
    {
        case (int)Calculator.Operation.Add:
            Calculator.Calculate(numberInput1, numberInput2, "+");
            break;
        case (int)Calculator.Operation.Subtract:
            Calculator.Calculate(numberInput1, numberInput2, "-");
            break;
        case (int)Calculator.Operation.Multiply:
            Calculator.Calculate(numberInput1, numberInput2, "*");
            break;
        case (int)Calculator.Operation.Divide:
            Calculator.Calculate(numberInput1, numberInput2, "/");
            break;
    }
} while (true);


