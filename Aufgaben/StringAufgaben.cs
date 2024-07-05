using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class StringAufgaben
    {
       
        /// <summary>
        /// Drucke den gegeben Text rückwärts, wobei jedes Zeichen mit einem Leerzeichen getrennt sein soll.
        /// Input: "Lagerregal"
        /// Output: "l a g e r r e g a L"
        /// Input: "Hamster"
        /// Output: "r e t s m a H"
        /// </summary>
        /// <param name="text"></param>
        internal static void PrintBackwards(string text) 
        {
            string output = ""; //Wert zuweisen, sonst Fehler in Schleife

            for (int i = text.Length - 1; i >= 0; i--) //rückwärts
            {
                output = output + text[i] + " ";            
            }

            Console.WriteLine(output);
        }

        /// <summary>
        /// Eine Funktion, welche die Anzahl von Worten in einer beliebigen Zeichenkette zählt.
        /// Ein Wort besteht aus mehreren zusammenhängenden Buchstaben und werden mit Leerzeichen voneinander getrennt.
        /// Input: "Hier könnte Ihre Werbung stehen!"
        /// Output: 5
        /// Input: "lorem ipsum dolor est"
        /// Ouput: 4
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        internal static int CountWords(string text) 
        { 
            int anzahl = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && (i == 0 || text[i - 1] == ' ')) //ohne i == 0 -> outofrange Fehler, ohne den Teil in der Klammer werden die Buchstaben gezählt
                { 
                    anzahl= anzahl + 1;
                }
            }
            return anzahl; 
        }


        /// <summary>
        /// Eine Funktion, welche die Anzahl an Buchstaben des letzten Wortes des Textes zurückgibt.
        /// <param name="text">Eine beliebig lange Sequenz an Text</param>
        /// <list type="bullet">
        /// <item>
        /// Input: "Mein Hamster hat meine Hausis gefressen"
        /// Output: 9
        /// </item>
        /// <item>
        /// Input: "Döner mit Scharf"
        /// Output: 6
        /// </item>
        /// </list>
        /// <returns>Die Anzahl an Buchstaben im letzten Wort als Int</returns>
        /// </summary>
        internal static int CountCharsOfLastWordInText(string text) 
        {
            int charcount = 0;
            text = text.Trim();
            for (int i = text.Length - 1; i >= 0; i--) 
            {
                if (text[i] != ' ') 
                { 
                    charcount++; 
                }
                else if (text[i] == ' ')
                {
                    break;
                }
            } 
        return charcount; 
        }

        /// <summary>
        /// Eine Funktion, welche einen beliebigen Text als Input bekommt und in der Konsole die Anzahl an Vokalen und Konsonanten anzeigt.
        /// Input: "Buxtehude"
        /// Output: Anzahl Vokale: 4
        ///         Anzahl Konsonanten: 5
        /// Input: "lorem ipsum dolor est"
        /// Output: Anzahl Vokale: 7
        ///         Anzahl Konsonanten: 11
        /// 
        /// HINT: Sind Leerzeichen Vokale oder Konsonanten?
        /// </summary>
        /// <param name="text"></param>
        internal static void PrintConsonantAndVowels(string text) { }
    }
}
