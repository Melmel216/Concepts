using StaticVSInstance;

do
{
    Console.Clear();
    Console.WriteLine("Was willst du rechnen?");
    Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide\n\t5.TriangleArea\n\t6.TrianglePerimeter\n\t7.Circle\n\t8.Rectangle");
    int menuInput = int.Parse(Console.ReadLine());

    var userSelect = (Operator)menuInput;
    
    switch (userSelect)
    {
        case Operator.Addition:
            Calculator.Calculate(Operator.Addition);
            break;
        case Operator.Subtraction:
            Calculator.Calculate(Operator.Subtraction);
            break;
        case Operator.Multiplication:
            Calculator.Calculate(Operator.Multiplication);
            break;
        case Operator.Division:
            Calculator.Calculate(Operator.Division);
            break;
        case Operator.TriangleArea:
            Calculator.CalculateTriangleArea();
            break;
        case Operator.TrianglePerimeter:
            Calculator.CalculateTrianglePerimeter();
            break;
        case Operator.Circle:
            Calculator.CalculateCircle();
            break;
        case Operator.Rectangle:
            Calculator.CalculateRectangle();
            break;
    }
} while (true);
