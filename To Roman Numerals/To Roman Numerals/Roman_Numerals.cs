using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Roman_Numerals
{
    public class Roman_Numerals
    {


        public static string Zahl_Uebersetzen(int zahl)
        {

            string fertige_Zahl = "";
            //Tausender
            fertige_Zahl += Tausender_Uebersetzen(zahl);

            //Hunderter

            fertige_Zahl += Hunderter_Uebersetzen(zahl);

            //Zehner
            fertige_Zahl += Zehner_Uebersetzen(zahl);

            //Einer
            fertige_Zahl += Einer_Uebersetzen(zahl);


            return fertige_Zahl;
        }

        
        internal static string Tausender_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            if (Tausender_Testen(zahl) < 4)
            {
                for (int i = 0; i < Tausender_Testen(zahl); i++)
                {
                    fertige_Zahl += "M";
                }
            }
            else
            {
                fertige_Zahl = "Fehler. Die Zahl ist zu groß";
            }

            return fertige_Zahl;
        }

        internal static string Hunderter_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            if (Hunderter_Testen(zahl) < 4)
            {
                for (int i = 0; i < Hunderter_Testen(zahl); i++)
                {
                    fertige_Zahl += "C";
                }
            }
            else if (Hunderter_Testen(zahl) == 4)
            {
                fertige_Zahl += "CD";
            }
            else if (Hunderter_Testen(zahl) == 5)
            {
                fertige_Zahl += "D";
            }
            else if (Hunderter_Testen(zahl) > 5 && Hunderter_Testen(zahl) < 9)
            {
                var ueberfive = Hunderter_Testen(zahl) - 5;
                fertige_Zahl += "D";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "C";
                }
            }
            else if (Hunderter_Testen(zahl) == 9)
            {
                fertige_Zahl += "CM";
            }

            return fertige_Zahl;
        }

        internal static string Zehner_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            if (Zehner_Testen(zahl) < 4)
            {
                for (int i = 0; i < Zehner_Testen(zahl); i++)
                {
                    fertige_Zahl += "X";
                }
            }
            else if (Zehner_Testen(zahl) == 4)
            {
                fertige_Zahl += "XL";
            }
            else if (Zehner_Testen(zahl) == 5)
            {
                fertige_Zahl += "L";
            }
            else if (Zehner_Testen(zahl) > 5 && Zehner_Testen(zahl) < 9)
            {
                var ueberfive = Zehner_Testen(zahl) - 5;
                fertige_Zahl += "L";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "X";
                }
            }
            else if (Zehner_Testen(zahl) == 9)
            {
                fertige_Zahl += "XC";
            }
            else
            {
                fertige_Zahl += "";
            }

            return fertige_Zahl;
        }

        internal static string Einer_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            if (Einer_Testen(zahl) < 4)
            {
                for (int i = 0; i < Einer_Testen(zahl); i++)
                {
                    fertige_Zahl += "I";
                }
            }
            else if (Einer_Testen(zahl) == 4)
            {
                fertige_Zahl += "IV";
            }
            else if (Einer_Testen(zahl) == 5)
            {
                fertige_Zahl += "V";
            }
            else if (Einer_Testen(zahl) > 5 && Einer_Testen(zahl) < 9)
            {
                var ueberfive = Einer_Testen(zahl) - 5;
                fertige_Zahl += "V";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "I";
                }
            }
            else if (Einer_Testen(zahl) == 9)
            {
                fertige_Zahl += "IX";
            }
            else
            {
                fertige_Zahl += "";
            }

            return fertige_Zahl;
        }

        internal static int Tausender_Testen(int zahl)
        {

            var tausendzahl = zahl - zahl % 1000;
            var newZahl = tausendzahl / 1000;

            return newZahl;
        }

        internal static int Hunderter_Testen(int zahl)
        {
            var Hundertzahl = zahl % 1000;
            var newZahl = Hundertzahl / 100;

            return newZahl;
        }

        internal static int Zehner_Testen(int zahl)
        {

            var zehnerzahl = zahl % 100;
            var newZahl = zehnerzahl / 10;

            return newZahl;
        }
        internal static int Einer_Testen(int zahl)
        {

            var einerzahl = zahl % 10;
            var newZahl = einerzahl / 1;

            return newZahl;
        }
    }


}