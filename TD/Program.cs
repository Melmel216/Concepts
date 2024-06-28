

int getIndex(string prompt)     //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

//Menü anzeigen mit Optionen

Console.WriteLine("Willkommen bei TD!");
List<string> todos = new();

do
{
    Console.Clear();
    Console.WriteLine("Was möchtest du tun?");
    Console.WriteLine("\t1. Neues Todo erstellen\n\t2. Todos anzeigen\n\t3. Todo löschen\n\t4. Todo updaten");
    var input = Console.ReadLine();

    switch (input)
    {
        case "1":
            Console.WriteLine("Was hast du zu tun? <Enter zum bestätigen>");
            var todo = Console.ReadLine();

            todos.Add(todo);

            Console.WriteLine("Todo hinzugefügt:" + todo);

            Thread.Sleep(2000);
            break;
        case "2":
            Console.WriteLine("Du hast folgende Aufgaben:");

            todos.ForEach(Console.WriteLine);

            Console.WriteLine("Drücke <Enter> um zurück ins Menü zu kommen.");
            Console.ReadKey();

            break;
        case "3":
            //Löschen

            //todos.ForEach(Console.WriteLine);
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }

            int todoIndex = getIndex("Welches Todo möchtest du löschen?");

            todos.RemoveAt(todoIndex);

            Console.WriteLine("Todo erfolgreich gelöscht.");
            Thread.Sleep(2000);
            break;
        case "4":
            //Updaten eines Todos (verändern des strings)
            //

            //todos.ForEach(Console.WriteLine);
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }

            int Index = getIndex("Welches Todo möchtest du anpassen?");

            //todos.RemoveAt(todoIndex);

            Console.WriteLine("Was möchtest du stattdessen tun?");

            var todoupdate = Console.ReadLine();
            todos[Index] = todoupdate;

            Console.WriteLine("Todo-Update erfolgreich:" + todoupdate);
            Thread.Sleep(2000);
            break;
    }
} while (true);







