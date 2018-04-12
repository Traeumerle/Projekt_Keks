using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Roman_Numerals;
using NUnit.Framework;

namespace Roman_Numerals_test
{
    [TestFixture]
    public class Roman_Numerals_test
    {
        [Test]
        public void test_fröhlich([Values(2525)]int input)
        {
            //Arrange
            //Act
            string output = Roman_Numerals.Zahl_Uebersetzen(input);

            //Assert
            Assert.AreEqual(output, "MMDXXV");
        }

    }
}
