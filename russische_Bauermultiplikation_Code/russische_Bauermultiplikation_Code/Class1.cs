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

            var x = russische_Bauern_übersetzen(47, 42);
            Russisch_ausgeben(x);
        }

        public static void Russisch_ausgeben(Dictionary<int, int> Kekse)
        {
            foreach (KeyValuePair<int, int> item in Kekse)
            {

                Console.WriteLine(item.Value);

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

        internal static Dictionary<int, int> russische_Bauern_übersetzen(int x, int y)
        {


            return russische_Bauern(x, y);
        }


        internal static int ersterWert(int x, int y)
        {

            return ersterWert(x, y);
        }

        public static Dictionary<int, int> russische_Bauern(int x, int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();


            if (x % 2 != 0)
            {
                Russisch.Add(x, y);
                do
                {

                    x = X_Berechnung(x);
                    y = Y_Berechnung(y);
                    if (x % 2 != 0)
                    {
                        Russisch.Add(x, y);
                    }
                } while (x != 1);
            }
            return Russisch;
        }

        public void x_verändern(int x)
        {
            x = x - x % 2;
            x = x / 2;
        }
    }
}
