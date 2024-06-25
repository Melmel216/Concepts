Console.WriteLine("Hello, World!");

/*
 PascalCase => WorttrennungenWerdenGroßgeschrieben (alle Anfangsbuchstaben groß)
 camelcase => worttrennungenWerdenGroßgeschrieben (erster Anfangsbuchstabe klein, die folgenden groß)
 snake_case => worttrennungen_werden_kleingeschrieben
 kebap-case => worttrennungen-werden-kleingeschrieben
 */


/*
 DateTime ist einer von vielen komplexen Datentypen in C#.
DateTime ist ein Strukturtyp, der Datum und Uhrzeit darstellt.
Komplexe Datentypen sind Objekte, die aus mehreren Werten bestehen, welche
ebenfalls komplex oder auch primitiv sein können. 
Objekte können nur in der Konsole ausgegeben werden, wenn sie eine
Methode ToString() haben.
 */

DateTime date = DateTime.Now;

Console.WriteLine(date.Year);


///////Funktionen


Console.WriteLine();


//Eigene Funktion einführen:
void PrintName()
{
    Console.WriteLine("Hello World!");
}

//Eigene Funktion aufrufen:
PrintName();
PrintName();
PrintName();

string GetGreeting()
{
    return "Herzlich Willkommen!";
}

var greeting = GetGreeting();

Console.WriteLine(greeting);


//chararrays
var my_array = "Feierabend!";
var my_letter = my_array[0];

//Collections Basics
//Array
string[] namen = new string[5];
string[] alternative_namen = ["A", "B", "C"];
namen[0] = "Tobi";
namen[1] = "Melanie";
namen[2] = "Torben";
Console.WriteLine(namen[0][0]);


//Array ist eine Liste an Werten
//Eine kontinuirliche Speicherregion, für mehrere Daten eines gewissen Types
int[] nums = new int[5];
