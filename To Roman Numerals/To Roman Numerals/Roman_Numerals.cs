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

            var fertige_Zahl = "";
            
            //Tausender
            fertige_Zahl += Tausender_Uebersetzen(zahl);

            //Hunderter
            fertige_Zahl += Hunderter_Uebersetzen(zahl);

            //Zehner
            fertige_Zahl += Zehner_Uebersetzen(zahl);

            //Einer
            fertige_Zahl += Einer_Uebersetzen(zahl);

            fertige_Zahl = dreitausend(zahl, fertige_Zahl);

            return fertige_Zahl;
        }


        public static string dreitausend(int zahl, string fertige_Zahl)
        {
            if (zahl > 3000)
            {
                fertige_Zahl = "Die Zahl ist zu groß!";
            }
            return fertige_Zahl;
        }

        internal static string Tausender_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            var tausender_zahl = Tausender_Testen(zahl);


            return Tausender_Zuweisung(tausender_zahl, fertige_Zahl);
        }

        internal static string Tausender_Zuweisung(int tausender_zahl,string fertige_Zahl)
        {

            if (tausender_zahl < 4)
            {
                for (int i = 0; i < tausender_zahl; i++)
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
            var hunderter_zahl = Hunderter_Testen(zahl);

            return Hunderter_Zuweisung(hunderter_zahl, fertige_Zahl);
        }

        internal static string Hunderter_Zuweisung(int hunderter_zahl, string fertige_Zahl)
        {
            
            if (hunderter_zahl < 4)
            {
                for (int i = 0; i < hunderter_zahl; i++)
                {
                    fertige_Zahl += "C";
                }
            }
            else if (hunderter_zahl == 4)
            {
                fertige_Zahl += "CD";
            }
            else if (hunderter_zahl == 5)
            {
                fertige_Zahl += "D";
            }
            else if (hunderter_zahl > 5 && hunderter_zahl < 9)
            {
                var ueberfive = hunderter_zahl - 5;
                fertige_Zahl += "D";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "C";
                }
            }
            else if (hunderter_zahl == 9)
            {
                fertige_Zahl += "CM";
            }

            return fertige_Zahl;
        }




        internal static string Zehner_Uebersetzen(int zahl)
        {
            string fertige_Zahl = "";
            var Zehner_zahl = Zehner_Testen(zahl);

            return Zehner_Zuweisung(Zehner_zahl, fertige_Zahl);
        }

        internal static string Zehner_Zuweisung(int zehner_zahl, string fertige_Zahl)
        {
            if (zehner_zahl < 4)
            {
                for (int i = 0; i < zehner_zahl; i++)
                {
                    fertige_Zahl += "X";
                }
            }
            else if (zehner_zahl == 4)
            {
                fertige_Zahl += "XL";
            }
            else if (zehner_zahl == 5)
            {
                fertige_Zahl += "L";
            }
            else if (zehner_zahl > 5 && zehner_zahl < 9)
            {
                var ueberfive = zehner_zahl - 5;
                fertige_Zahl += "L";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "X";
                }
            }
            else if (zehner_zahl == 9)
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
            var Einer_zahl = Einer_Testen(zahl);

            return Einer_Zuweisung(Einer_zahl, fertige_Zahl);
        }

        internal static string Einer_Zuweisung(int einer_zahl, string fertige_Zahl)
        {
            if (einer_zahl < 4)
            {
                for (int i = 0; i < einer_zahl; i++)
                {
                    fertige_Zahl += "I";
                }
            }
            else if (einer_zahl == 4)
            {
                fertige_Zahl += "IV";
            }
            else if (einer_zahl == 5)
            {
                fertige_Zahl += "V";
            }
            else if (einer_zahl > 5 && einer_zahl < 9)
            {
                var ueberfive = einer_zahl - 5;
                fertige_Zahl += "V";
                for (int i = 0; i < ueberfive; i++)
                {
                    fertige_Zahl += "I";
                }
            }
            else if (einer_zahl == 9)
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