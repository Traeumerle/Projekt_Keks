using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kekse_Neu;
using NUnit.Framework;

namespace KlasseTest
{
    [TestFixture]
    public class Testkekse

    {
        [Test, Category("Akzeptanztest")]
        public void Zahlen_zwischen_untergrenze_obergrenze()
        {
            var ergebnis = Keks_Neu.Start_Zahlen_testen(3, 5);
            Assert.AreEqual(new[] {3, 4, 5 }, ergebnis.ToArray());
        }
        [Test, Category("Gerüst")]
        public void Anzahl_Zahlen()
        {
            var ergebnis = Keks_Neu.Zahlen_testen(-1, 45);
            Assert.AreEqual(47, ergebnis.Count());
        }
    }

}
