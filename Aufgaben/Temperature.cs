using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Aufgaben
{
    internal class Temperature
    {
        
        //Aufgabe 1:
        internal static List<int> TageÜberSchwelle(List<int>Gradzahlen, int schwelle)
        {
            List<int> IndexListe = new();
            schwelle = 21;
            for (int i = 0; i < Gradzahlen.Count; i++)
            {
                if (Gradzahlen[i] > schwelle)
                {
                    IndexListe.Add(i);
                }
            }
            return IndexListe;
        }

        //Aufgabe 2:
        internal static double TemperaturDurchschnitt(List<int> Gradzahlen)
        {
            double summe = 0;
            double durchschnitt;

            for (int i = 0; i < Gradzahlen.Count; i++)
            {
                summe = summe + Gradzahlen[i];
            }

            durchschnitt = summe / Gradzahlen.Count;
            
            return durchschnitt;
        }
    }
}
