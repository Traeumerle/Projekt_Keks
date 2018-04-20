using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDictionary_Code;

namespace ToDictionary_Test
{   
    [TestFixture]
    public class ToDictionary_Test
    {

        [Test]
        public void test_Strings1()
        {
            //Arrange
            
            //Act
            var input = ToDictionary_Code.ToDictionary_Code.Uebersetze_DictionaryCase1("a = 1; b = 2; c = 3").Count;

            //Assert
            Assert.AreEqual(input, 3);
        }

        [Test]
        public void test_Strings2()
        {
            //Arrange

            //Act
            var input = ToDictionary_Code.ToDictionary_Code.Uebersetze_DictionaryCase1("a=1;a=2").Count;

            //Assert
            Assert.AreEqual(input, 1);
        }
    }
}
