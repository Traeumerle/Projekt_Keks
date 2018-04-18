using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace russische_Bauermultiplikation_Code
{
    public class Class1
    {

        public static void Russisch_ausgeben(Dictionary<int, int> Kekse)
        {
            foreach(KeyValuePair<int, int> item in Kekse)
            {
                Console.WriteLine(item.Value);
            }
        }

        public static int X_Berechnung(int x)
        {
            x = x - x % 2;
            x = x / 2;
            return x;
        }
        public static int Y_Berechnung(int y)
        {
            y = y * 2;
            return y;
        }
        public static int Multipliziere(int x, int y)
        {
            int rückgabeX = x ;
            return rückgabeX;
        }
        public static Dictionary<int, int> russische_Bauern(int x, int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();
            do
            {
                x = X_Berechnung(x);
                y = Y_Berechnung(y);
                Russisch.Add(x, y);
            } while (x != 1);
            return Russisch;
        }
    }
}
