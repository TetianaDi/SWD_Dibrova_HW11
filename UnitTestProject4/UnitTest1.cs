using NUnit.Framework;
using System;

namespace UnitTestProject4
{

    public class UnitTest1
    {
        [Category ("HW11")]
        //[Test]
        //public void Positive_MultiplicationTwoNumbers()
        //{
        //    // Arrange

        //    int firstNumber = 2;
        //    int secondNumber = 3;
        //    int expectedResult = 6;

        //    // Act

        //    int actualResult = Calculator.MultiplyTwoNumbers(firstNumber, secondNumber);

        //    // Assert

        //    Assert.True(actualResult == expectedResult,
        //        $"Product of '{firstNumber}' and '{secondNumber}' isn't equal '{expectedResult}' as expected." +
        //        $"Actual product is '{actualResult}'");
        //}

        [Test]
        public void Negative_MultiplicationTwoNumbers_ExpectedExeption()
        {
            // Arrange

            int firstNumber = 8;
            int secondNumber = 3;
            int expectedResult = 6;

            // Act
            // Assert

            Assert.Throws<ArgumentException>(() =>  Calculator.MultiplyTwoNumbers
            (firstNumber,secondNumber),
                $"Number '{firstNumber}' or '{secondNumber}' is in exeption (> 1000 or < -1000");

        }
    }
}
