

int getIndex(string prompt)     //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

void Start()
{
    Console.Clear();
    Console.WriteLine("Was möchtest du tun?");
    Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo löschen\n\t4. Todo updaten");
}

//Aufgabe für's Wochenende:
//Erstelle eine Funktion für die Ausgabelogik der Liste
// -> printListItems()
//Was könnten weitere nützliche Funktionen für unsere App sein?

//Funktion für "Drücke Enter um ins Menü zurückzukehren
// -> returnToMenu()

//Funktion für den Start?
// -> Start()


//Menü anzeigen mit Optionen

Console.WriteLine("Willkommen bei TD!");
List<string> todos = new();

do
{
    Start();

    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            //Todo Eingabe
            Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
            var todo = Console.ReadLine();

            todos.Add(todo);

            Console.WriteLine("Todo hinzugefügt:" + todo);

            returnToMenu();
            break;
        case "2":
            //Todos anzeigen lassen
            Console.WriteLine("Du hast folgende Aufgaben:");

            printListItems();

            returnToMenu();
            break;
        case "3":
            //Löschen

            printListItems();

            int todoIndex = getIndex("Welches Todo möchtest du löschen?");

            todos.RemoveAt(todoIndex);

            Console.WriteLine("Todo erfolgreich gelöscht.");

            returnToMenu();
            break;
        case "4":
            //Updaten eines Todos (verändern des strings)

            printListItems();

            int Index = getIndex("Welches Todo möchtest du anpassen?");

            Console.WriteLine("Was möchtest du stattdessen tun?");

            var todoupdate = Console.ReadLine();
            todos[Index] = todoupdate;

            Console.WriteLine("Todo-Update erfolgreich:" + todoupdate);

            returnToMenu();
            break;
    }
} while (true);

/*
void => no type
Function argument: int myFunc(void) -- the function takes nothing.

Function return value: void myFunc(int) -- the function returns nothing
 */
void printListItems()
{
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"\t{i}. {todos[i]}");
    }
}

void returnToMenu()
{
    Console.WriteLine("Drücke <Enter> um zurück ins Menü zu kommen.");
    Console.ReadKey();
}





