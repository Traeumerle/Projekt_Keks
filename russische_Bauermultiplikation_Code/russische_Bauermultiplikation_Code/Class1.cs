using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russische_Bauermultiplikation_Code
{
    public class Class1
    {
        public static void Main(string[] args)
        {
            var x = bearbeite_Bauern(47, 42);
            Russisch_ausgeben(x);


        }


        public static void Russisch_ausgeben(Dictionary<int, int> Kekse)
        {
            foreach (KeyValuePair<int, int> item in Kekse)
            {

                Console.WriteLine(item);

            }
        }

        public static int X_Berechnung(int x)
        {
            x = (x - x % 2) / 2;
            return x;
        }

        public static int Y_Berechnung(int y)
        {
            y = y * 2;
            return y;
        }


        public static Dictionary<int, int> bearbeite_Bauern(int x, int y)
        {

            Dictionary<int, int> Russisch = new Dictionary<int, int>();

            unterste_Bauern(x, y, Russisch);
            unterste_Bauern(x = X_Berechnung(x), y = Y_Berechnung(y), Russisch);
            unterste_Bauern(x = X_Berechnung(x), y = Y_Berechnung(y), Russisch);
            unterste_Bauern(x = X_Berechnung(x), y = Y_Berechnung(y), Russisch);
            unterste_Bauern(x = X_Berechnung(x), y = Y_Berechnung(y), Russisch);
            unterste_Bauern(x = X_Berechnung(x), y = Y_Berechnung(y), Russisch);


            return Russisch;
        }

        public static void unterste_Bauern(int x, int y, Dictionary<int, int> Russisch)
        {

            if (x % 2 != 0)
            {
                Russisch.Add(x, y);
            }


        }



    }
}
