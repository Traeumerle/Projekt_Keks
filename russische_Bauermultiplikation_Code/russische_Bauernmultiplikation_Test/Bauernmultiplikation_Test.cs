using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using russische_Bauermultiplikation_Code;

namespace russische_Bauernmultiplikation_Test
{
    [TestFixture]
    public class Bauernmultiplikation_Test
    {
        [Test]
        public void test_fröhlich()
        {
            //Arrange
            //Act
            int output = Bauernmultiplikation_Code.Russisch_Erg(47,42);

            //Assert
            Assert.AreEqual(output, 1974);
        }
    }
}
