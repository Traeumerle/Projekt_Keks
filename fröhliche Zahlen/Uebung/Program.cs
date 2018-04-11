using FizzBuzzReal.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uebung
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "23";
            int y = x.Length;
            int start = 0;
            int length = 1;
            for (int i = start; i < y; i++)
            {
                String substringZahl = x.Substring(start, length);


            double xy = Math.Pow(Convert.ToDouble(substringZahl),2);
            Console.WriteLine(xy);
            }
            Console.ReadLine();
        }
    }
}
