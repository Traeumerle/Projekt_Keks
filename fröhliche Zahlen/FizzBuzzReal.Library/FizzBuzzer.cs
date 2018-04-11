using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzReal.Library
{
    public class FizzBuzzer
    {
        
        public static string Zahlen_Testen(string x)
        {
            double xy;
            do
            {
                xy = 0;
                for (int i = 0; i < x.Length; i++)
                {
                    string substringZahl = x.Substring(i, 1);
                    xy += Math.Pow(Convert.ToDouble(substringZahl), 2);
                }
                x = Convert.ToString(xy);
            } while (xy != 1 && xy != 4);
            return x;
        }
     
    }
}
