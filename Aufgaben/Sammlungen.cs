using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal static class Sammlungen
    {
        /// <summary>
        /// Eine Funktion, welche eine Sammlung und ein gesuchtes Element übergeben bekommt, 
        /// und den entsprechenden Index des Elements im Array zurück gibt.
        /// </summary>
        internal static int FindIndex(List<int> numbers, int query)
        {
            
            foreach (int i in numbers)
            {
                if (numbers[i] == query) return i;
            }
            return -1;
        }
    }
}
