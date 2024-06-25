
//Menü anzeigen mit Optionen

Console.WriteLine("Willkommen bei TD!");
Console.WriteLine("Was möchtest du tun?");
Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen");

do
{
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            //Option 1: Todo erstellen

            //Userinput nehmen

            //Todo erstellen
            Console.WriteLine("CREATE");
            
            break;
        case "2":
            //Liste der Todos anzeigen
            Console.WriteLine("READ");
            break;
    }
} while (false);





