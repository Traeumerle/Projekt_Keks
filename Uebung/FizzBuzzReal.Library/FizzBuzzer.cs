using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzReal.Library
{
    public class FizzBuzzer
    {
        
 


        public static string GetValue(int input)
        {
            string output = string.Empty;

            if (input % 3 == 0)
                output += "Fizz";
            if (input % 5 == 0)
                output += "Buzz";
            if (string.IsNullOrEmpty(output))
                output = input.ToString();
            return output;
        }

        public static Dictionary<int, string> dicterstellen(int untergrenze, int obergrenze)
        {
            Dictionary<int, string> Werte = new Dictionary<int, string>();
            for (int i = untergrenze; i <= obergrenze; i++)
            {
                Werte.Add(i,GetValue(i));
            }


            return Werte;
        }
    }
}
