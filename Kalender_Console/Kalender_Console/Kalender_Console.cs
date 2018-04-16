using Kalender_Konsole_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalender_Console
{
    class Kalender_Console
    {
        static void Main(string[] args)
        {

                // first Day of Month
                var month = new DateTime(2018, 5, 2);

                // Month/Year -> DaysofWeek  
                // align year right           
                var kopfzeile = new string(' ', 16 - month.ToString("MMMM").Length);
                Console.WriteLine($"{month.ToString("MMMM")}{kopfzeile}{month.Year}");
                Console.WriteLine(new string('_', 20));
                Console.WriteLine("So Mo Di Mi Do Fr Sa");

                //leere Tage des Monats
                var leereTage = (int)month.DayOfWeek;
                var currentDay = month;

                //wieviele Tage = Looptimes + leereTage = freie stellen
                var iterations = DateTime.DaysInMonth(month.Year, month.Month) + leereTage;
                for (int j = 0; j < iterations; j++)
                {
                    // Pad the first week with empty spaces if needed
                    if (j <leereTage)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        // Write the day - pad left adds a space before single digit days
                        Console.Write($"{currentDay.Day.ToString().PadLeft(2, ' ')} ");

                        // If we've reached the end of a week, start a new line
                        if ((j + 1) % 7 == 0)
                        {
                            Console.WriteLine();
                        }

                        // Increment our 'currentDay' to the next day
                        currentDay = currentDay.AddDays(1);
                    }
                }

                // Put a blank space between months
                Console.WriteLine("\n");

            Console.ReadLine();
        }

        public static string Eingabe(string eingabe)
        {
            Console.WriteLine("C:>");
            eingabe = Console.ReadLine();
            return eingabe;
        }


    }
}
