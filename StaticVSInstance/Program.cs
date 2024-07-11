﻿using StaticVSInstance;

decimal numberInput1 = 0;
decimal numberInput2 = 0;
decimal result = 0;

do
{
    Console.Clear();
    Console.WriteLine("Was willst du rechnen?");
    Console.WriteLine("\t1.Add\n\t2.Subtract\n\t3.Multiply\n\t4.Divide\n\t5.Triangle\n\t6.Circle\n\t7.Rectangle");
    int menuInput = int.Parse(Console.ReadLine());

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
        case Operator.Triangle:
            Calculator.CalculateTriangle();
            break;
        case Operator.Circle:
            Calculator.CalculateCircle();
            break;
        case Operator.Rectangle:
            Calculator.CalculateRectangle();
            break;
    }
} while (true);
