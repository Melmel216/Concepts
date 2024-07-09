// KlassenAufgaben

//Book-Aufgabe

//Instanzen erstellen:

using Buchverwaltungssystem;

Book book1 = new Book("Storm Front", "Jim Butcher", 2000, "9783867621113");
Book book2 = new Book("Fool Moon", "Jim Butcher", 2000, "9783867621120");
Book book3 = new Book("Grave Peril", "Jim Butcher", 2001, "9783867621137");

//Aufruf der Methode GetDescription + Ausgabe in der Konsole 
Console.WriteLine(book1.GetDescription());
Console.WriteLine(book2.GetDescription());
Console.WriteLine(book3.GetDescription());
