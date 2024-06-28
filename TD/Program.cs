
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

            break;
        case "2":
            Console.WriteLine("Du hast folgende Aufgaben:");

            todos.ForEach(Console.WriteLine);

            Console.WriteLine("Drücke <Enter> um zurück ins Menü zu kommen.");
            Console.ReadKey();
            
            break;
        case "3":
            //Löschen
            Console.WriteLine("Welches Todo möchtest du löschen?");

            //todos.ForEach(Console.WriteLine);
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }
            var todoIndexString = Console.ReadLine();
            int todoIndex = int.Parse(todoIndexString);

            todos.RemoveAt(todoIndex);
            
            Console.WriteLine("Todo erfolgreich gelöscht.");
            break;
        case "4":
            //Updaten eines Todos (verändern des strings)
            //
            Console.WriteLine("Welches Todo möchtest du updaten?");

            //todos.ForEach(Console.WriteLine);
            for (int i = 0; i < todos.Count; i++)
            {
                Console.WriteLine($"\t{i}. {todos[i]}");
            }

            todoIndexString = Console.ReadLine();
            todoIndex = int.Parse(todoIndexString);

            //todos.RemoveAt(todoIndex);

            Console.WriteLine("Bitte gebe die Änderung ein:");

            var todoupdate = Console.ReadLine();
            todos[todoIndex] = todoupdate;
            
            Console.WriteLine("Todo-Update erfolgreich:" + todos[todoIndex]);
            break;
    }
} while (true);







