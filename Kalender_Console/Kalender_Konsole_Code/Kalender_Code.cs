using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender_Konsole_Code
{
    public class Kalender_Code
    {

        public static string Kalendar_ausgabe(string cal)
        {

            Console.WriteLine("        Monat/Jahr        ");
            Console.WriteLine("So  Mo  Di  Mi  Do  Fr  Sa");
            Console.WriteLine(" 1   2   3   4   5   6   7");
            Console.WriteLine(" 8   9  10  11  12  13  14");
            Console.WriteLine("15  16  17  18  19  20  21");
            Console.WriteLine("22  23  24  25  26  27  28");
            Console.WriteLine("29  30  31  --  --  --  --");

            return cal;
        }

        public static Calendar Kalender_test(string cal)
        {
            GregorianCalendar Projekt = new GregorianCalendar();
                return Projekt;
        }
        


    }
}
