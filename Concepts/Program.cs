using Concepts;

Person person1 = new Person(); //Konstruktoraufruf

//Erstellen eines neuen Objekts durch Aufrufen einer Konstruktor-Methode
//var person2 = new Person("Michael", "Lutz");


person1.Vorname = "Michael";
person1.Nachname = "Lutz";
person1.Greet("Hallo!"); //Kann Fehler verursachen, wenn Vorname und Nachname nicht initialisiert sind. Vorname und Nachname müssen vorher gesetzt sein

Console.WriteLine(person1); //Druckt Namespace.Klasse

