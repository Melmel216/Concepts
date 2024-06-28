var input = Console.ReadLine();
// int index = Convert.ToInt32(input);
// int index = int.Parse(input);
//bool error = int.TryParse(input, out int index);

//if (!error)
//{
//    Console.WriteLine(error);
//}
//else
//{
//    Console.WriteLine(index);
//}

//Beispiel: Funktion/Methode mit Parameter
//Eine Funktion kann keinen, einen oder beliebig viele Parameter bekommen
//Die Parameter können die Funktionsweise einer Methode dynamisch ändern


//Aufgabe für's Wochenende:
//Erstelle eine Funktion für die Ausgabelogik der Liste
//Was könnten weitere nützliche Funktionen für unsere App sein?



int getIndex(string prompt)     //Funktionssignatur
{
    Console.WriteLine(prompt);
    var input = Console.ReadLine();
    var number = int.Parse(input);
    return number;
}

List<string> todos = new();

todos.Add("Wäsche waschen");
todos.Add("Bügeln");

int index = getIndex("Gebe die Aufgabe ein, die du bearbeiten willst:");
//int my_second_index = getIndex(); // kann beliebig oft aufgerufen werden
Console.WriteLine(todos[index]);