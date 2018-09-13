using System;
using System.Collections.Generic;


namespace ToDictionary_Code
{
    public class ToDictionary_Code
    {

        public static void Dicterstellen(Dictionary<string, string> todictionary)
        {
            foreach (var item in todictionary)
            {
                Console.WriteLine("Key: " + item.Key + " Value: " + item.Value);
            }
        }

        public static Dictionary<string, string> Uebersetze_DictionaryCase1(string x)
        {
            Dictionary<string, string> ToDictionary = new Dictionary<string, string>();

            string[] y;
            string[] ly = { string.Empty };
            string[] split_string = x.Split(new Char[] { ';' });
            for (int i = 0; i < split_string.Length; i++)
            {
                x = split_string[i];
                y = x.Split(new Char[] { '=' });
                if (ly[0] != y[0])
                {
                    ToDictionary.Add(y[0], y[1]);
                    ly[0] = y[0];
                }
                else
                {
                    ToDictionary[y[0]] = y[1];
                }
            }
            return ToDictionary;
        }
    }
}
