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
            var ergebnis = FröhlicheZahlen.Happyloop("19");
            Assert.AreEqual("1", ergebnis);
        }
        [Test, Category("Gerüst")]
        public void Anzahl_Zahlen()
        {
            var ergebnis = FröhlicheZahlen.Happyloop("19");
            Assert.AreEqual(1, ergebnis.Length);
        }
    }

}
