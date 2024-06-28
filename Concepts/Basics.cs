using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concepts
{
    internal class Basics
    {
        internal void Run()
        {
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
        }
    }
}
