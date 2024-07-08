namespace Concepts
{
    /// <summary>
    /// Eine Klasse ist ein selbst-definierter Datentyp.
    /// Eine Klasse instanziiert ein Objekt vom Typ der Klasse.
    /// Eine Klasse besitzt Eigenschaften und Methoden.
    /// Vor dem Keyword class (oder dem Return-Type einer Funktion/Methode) lässt ich ein Access-Modifier definieren 
    /// Access-Modifier definieren an welchen Stellen im Code die jeweilige Klasse oder Methode oder Eigenschaft (Properties) sich aufrufen lässt. 
    /// Access-Modifier
    /// 
    /// 
    /// </summary>
    internal class Person
    {
        //Eigenschaft => Eine Variable für dieses Objekt
        //Auch Eigenschaften haben Access-Modifier
        internal string Vorname;
        internal string? Nachname; //Dieser string ist nullable => kann uninitialisiert sein.

        /// <summary>
        /// Konstruktor für diese Klasse.
        /// Ein Konstruktor erstellt für uns eine Instanz (Objekt) von dieser Klasse (DatenTyp).
        /// </summary>
        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        //Methode => Eine Aktion, welche mein Objekt tätigen kann
        internal void Greet(string greeting)
        {
            Console.WriteLine(Vorname + " " + Nachname + " Begrüßt dich mit: " + greeting);
        }
    }
}
