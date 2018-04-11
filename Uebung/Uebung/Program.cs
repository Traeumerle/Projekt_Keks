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
            Console.WriteLine("Bitte Untergrenze angeben: ");
            int untergrenze = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte Obergrenze angeben: ");
            int obergrenze = Convert.ToInt32(Console.ReadLine());


            var Kekse = FizzBuzzer.dicterstellen(untergrenze, obergrenze);
            foreach (KeyValuePair<int, string> item in Kekse)
            {
                Console.WriteLine(item.Value);
            }
                
            
            Console.ReadLine();
        }
    }
}
