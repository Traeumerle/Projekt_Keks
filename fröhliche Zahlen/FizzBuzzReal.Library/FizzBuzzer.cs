using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzReal.Library
{
    public class FizzBuzzer
    {
        
        public static int zahlen_Testen(string x)
        {
           x = "23";
            int y = x.Length;
            int start = 1;
            int length = 1;
            for (int i = start; i <= y; i++)
            {
                String substringZahl = x.Substring(start, length);
                Math.Sqrt(Convert.ToInt32(substringZahl));
                Console.WriteLine(substringZahl);
            }
            Console.ReadLine();
           
            
            //while(x != "1" || x != "4")
            //{
               
            //    Math.Sqrt(Convert.ToInt32(x));
            //}


            return Convert.ToInt32(x);


        }
     
    }
}
