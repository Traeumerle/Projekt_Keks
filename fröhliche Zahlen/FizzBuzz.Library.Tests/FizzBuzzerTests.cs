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



        //    [Test]
        //    public void Buzzer_WhenDefault_ReturnsInput([Values(1,2,4,7,8,11,13,14,16,17,19)]int input)
        //    {
        //        //Arrange
        //        //Act
        //        string output = FizzBuzzer.GetValue(input);
        //        //Assert
        //        Assert.AreEqual(input.ToString(), output);
        //    }

        //    [Test]
        //    public void Fizz_Whendiv3_ReturnsFizz([Values(3,6,9,12,18)]int input)
        //    {
        //        string output = FizzBuzzer.GetValue(input);

        //        Assert.AreEqual("Fizz", output);
        //    }

        //    [Test]
        //    public void Fizz_Whendiv5_ReturnsBuzz([Values(5,10)]int input)
        //    {


        //        string output = FizzBuzzer.GetValue(input);

        //        Assert.AreEqual("Buzz", output);
        //    }
        //}
    }
}