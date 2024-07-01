

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

//Funktion für "Drücke Enter um ins Menü zurückzukehren?
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

            ReturnToMenu();
            break;
        case "2":
            //Todos anzeigen lassen
            PrintListItems("Du hast folgende Todos:");

            ReturnToMenu();
            break;
        case "3":
            //Löschen

            PrintListItems("Du hast folgende Todos:");

            int todoIndex = getIndex("Welches Todo möchtest du löschen?");

            string todoToRemove = todos[todoIndex];
            todos.RemoveAt(todoIndex);

            Console.WriteLine($"GELÖSCHT:  {todoToRemove}");
            PrintListItems("Aktualisierte Todo-Liste:");
            ReturnToMenu();
            break;
        case "4":
            //Updaten eines Todos (verändern des strings)

            PrintListItems("Du hast folgende Todos:");

            int Index = getIndex("Welches Todo möchtest du anpassen?");

            Console.WriteLine("Was möchtest du stattdessen tun?");

            var todoupdate = Console.ReadLine();
            todos[Index] = todoupdate;

            Console.WriteLine("Text verändert:" + todoupdate);

            ReturnToMenu();
            break;
    }
} while (true);

/*
void => no type
Function argument: int myFunc(void) -- the function takes nothing. void kann man hier weglassen

Function return value: void myFunc(int) -- the function returns nothing
 */
void PrintListItems(string prompt)   //kein static, weil gehört zu Objekt?
{
    Console.WriteLine(prompt);
    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"\t{i}. {todos[i]}");
    }
}

void ReturnToMenu()
{
    Console.WriteLine("Drücke <Enter> um zurück ins Menü zu kommen.");
    Console.ReadKey();
}





