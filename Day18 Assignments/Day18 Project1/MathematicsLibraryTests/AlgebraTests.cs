using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathematicsLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathematicsLibrary.Tests
{
    [TestClass()]
    public class AlgebraTests
    {
        [TestMethod()]
        public void FactorialTest_Zero_Input()
        {
            //Arrange
            int n = 0;
            int expected = 1;

            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_One_To_Seven_Input()
        {
            //Arrange
            int n = 4;
            int expected = 24;


            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Negative_Input()
        {
            //Arrange
            int n = -5;
            int expected = -9999;


            //Act
            int actual = Algebra.Factorial(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void FactorialTest_Greater_Than_Seven_Input()
        {
            //Arrange
            int n = 9;
            int expected = -999;

            //Act
            int actual = Algebra.Factorial(n);


            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void Palindrome_Right_Input_Test()
        {
            //Arrange 
            int n = 23532;
            string expected = "Palindrome";

            //Act
            string actual = Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected,actual);
        }


        [TestMethod()]
        public void Palindrome_Wrong_Input_Test()
        {
            //Arrange
            int n = 1566;
            string expected = "Not Palindrome";

            //Act
            string actual = Algebra.Palindrome(n);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}