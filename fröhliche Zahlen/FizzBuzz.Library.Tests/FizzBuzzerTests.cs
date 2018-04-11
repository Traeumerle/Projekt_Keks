using FizzBuzzReal.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Library.Tests
{
    [TestFixture]
    public class FizzBuzzerTests
    {

        [Test]
        public void test_fröhlich([Values("1", "100", "7", "97", "44", "49")]string input)
        {
            //Arrange
            //Act
            string output = FizzBuzzer.zahlen_Testen(input);

            //Assert
            Assert.AreEqual(output, "1");
        }

        [Test]
        public void test_unfröhlich([Values("11", "99", "8", "25", "47", "34")]string input)
        {
            //Arrange
            //Act
            string output = FizzBuzzer.zahlen_Testen(input);

            //Assert
            Assert.AreEqual(output, "4");
        }
    }
}