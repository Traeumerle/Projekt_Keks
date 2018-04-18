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

            looping(47,42);
            

            
        }


        public static Dictionary<int, int> russische_Bauern_loop(int x, int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();

            Russisch =  russische_Bauern_einleitung(x = X_Berechnung(x), y = Y_Berechnung(y));
            Beenden();
            russische_Bauern_loop(x, y);

            return Russisch;

        }

        public static void Beenden()
        {

        }

        public static Dictionary<int, int> looping( int x , int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();

            russische_Bauern_einleitung(x, y);
            russische_Bauern_loop(x, y);

            return Russisch;
        }
        public static Dictionary<int, int> russische_Bauern_einleitung(int x, int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();

            russische_Bauern(x, y);

            return Russisch;
            
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



        public static Dictionary<int, int> russische_Bauern(int x, int y)
        {
            Dictionary<int, int> Russisch = new Dictionary<int, int>();

            Russisch.Add(x, y);
            
            return Russisch;
        }


    }
}
