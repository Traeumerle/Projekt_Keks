using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDictionary_Code
{
    public class ToDictionary_Code
    {

        public static Dictionary<string, string>Dicterstellen(string x)
        {
            Dictionary<string, string> ToDictionary = new Dictionary<string, string>();

            string uebersetztes_x = Uebersetze_DictionaryCase1(x);
            ToDictionary.Add(x, uebersetztes_x);

            return ToDictionary;
        }

        public static string Uebersetze_DictionaryCase1(string x)
        {
            string[] split_string = x.Split(new Char[] { ';'});
            return Convert.ToString(split_string);
        }

        public static void Ausgabe(string x, Dictionary<string, string> Kekse)
        {
            foreach (var item in Kekse)
            {
                Console.WriteLine(Dicterstellen(x));
            }
            
        }

    }
}
