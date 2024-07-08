do
{
    Console.WriteLine("---ExpensesTracker---");
    Console.WriteLine("Was willst du tun?");
    Console.WriteLine("\t1. Neue Ausgabe angeben.");
    Console.WriteLine("\t2. Eine Ausgabe löschen.");
    var input = Console.ReadLine();
    switch (input)
    {
        case "1":
            Console.WriteLine("neu");
            break;
        case "2":
            Console.WriteLine("entfernen");
            break;
    }
    Thread.Sleep(2000);
    Console.Clear();
} while (true);