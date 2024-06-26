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

/*
 * JavaScript
 function printName() {
  console.log("Hello World!");
 }
 * Python
 def printName():
   print("Hello World!")
 # hier gehts dann weiter
 */


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
//Ein Array hat immer eine feste Größe, welche bei der Initialisierung festgelegt 
//werden muss
//Array.Length ist immer die maximale Länge des Arrays, sprich 
//leere Plätze im Array zählen immer mit
int[] nums = new int[5];
nums[0] = 10;

/*
 For-Loop - 4 Komponenten 
    1. Deklaration der Zählervariablen
    2. Bedingung der Schleife (Wann zu Ende?)
    3. Operation, welche nach jeder Iteration ausgeführt wird
        -> idr. Inkrement (i++) oder Dekrement (i--)
    4. Codeblock (Function Body),  welcher definiert, was bei jeder Iteration der 
       Schleife passieren soll. 
 */
for (int i = 0; i < nums.Length; i++)
{
    Console.WriteLine(nums[i]);
}