using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBAL.Tests
{
    [TestFixture]
    public class MagicianTests
    {
        [Test]
        public void DoMagic_Testing1()
        {
            //Arrange
            int expectedResult = 10;
            //Act
            Magician magObj = new Magician();
            int result = magObj.DoMagic("ABC");

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        public void DoMagic_Testing2()
        {
            //Arrange
            int expectedResult = 20;
            //Act
            Magician magObj = new Magician();
            int result = magObj.DoMagic("XYZ");

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
        [Test]
        public void DoMagic_Testing3()
        {
            //Arrange
            int expectedResult = 30;
            //Act
            Magician magObj = new Magician();
            int result = magObj.DoMagic("");

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestCase("ABC",10)]
        [TestCase("XYZ", 20)]
        [TestCase("X", 30)]
        [TestCase("", 30)]
        public void DoMagic_Testing(String inputValue, int expectedResult)
        {
            //Arrange
            //int expectedResult = 10;
            //Act
            Magician magObj = new Magician();
            int result = magObj.DoMagic(inputValue);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
