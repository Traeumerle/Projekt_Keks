using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kekse_Neu
{
    public class FröhlicheZahlen
    {
        public static List<string> Start_Zahlen_testen(string zahl)
        {
            var Zahlen = Zahlen_testen(zahl);
            return Zahlen;
        }
        internal static List<string> Zahlen_testen(string zahl)
        {
            var Zahlen = new List<string>();
            for (int ziffer = 0; ziffer < zahl.Length; ziffer++)
            {
                string substringZahl = zahl.Substring(ziffer, 1);
                Zahlen.Add(substringZahl);
            }
            return Zahlen;
        }

        internal static string Potenzieren(string zahl)
        {
            var list = Zahlen_testen(zahl);
            double potenz = 0;
            foreach(string zahlen in list)
            {
                potenz += Math.Pow(Convert.ToDouble(zahlen), 2);
            }

            return Convert.ToString(potenz);
        }
        
        internal static string Happyloop(string zahl)
        {
            var happy = "";
            do
            {
                happy = Potenzieren(zahl);
            } while (happy != "1" && happy != "4");
            
            return happy;
        }

    }
}
