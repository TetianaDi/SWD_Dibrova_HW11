using NUnit.Framework;
using System;

namespace UnitTestProject4
{

    public class UnitTest1
    {
        [Category ("HW11")]

        [Test]
        public void Positive_MultiplicationTwoNumbers()
        {
            // Arrange

            int firstNumber = 10;
            int secondNumber = 2;
            int expectedResult = 20;

            // Act

            int actualResult = Calculator.MultiplyTwoNumbers(firstNumber, secondNumber);

            // Assert

            Assert.True(actualResult == expectedResult,
                $"Product of '{firstNumber}' and '{secondNumber}' isn't equal '{expectedResult}' as expected." +
                $"Actual product is '{actualResult}'");
        }

        [Test]
        public void Negative_NumberMoreThan1000_MultiplicationTwoNumbers_ExpectedExeption()
        {
            // Arrange

            int firstNumber = 1001;
            int secondNumber = 3;
            
            // Act
            // Assert

            Assert.Throws<Exception>(() =>  Calculator.VerifyNumbers (firstNumber),
            
                $"Number '{firstNumber}' or '{secondNumber}' is in exeption (> 1000 or < -1000");

        }


        [Test]
        public void Negative_NumberMoreThanMinus1000_MultiplicationTwoNumbers_ExpectedExeption()
        {
            // Arrange

            int firstNumber = -1001;
            int secondNumber = 3;

            // Act
            // Assert

            Assert.Throws<Exception>(() => Calculator.VerifyNumbers(firstNumber),

                $"Number '{firstNumber}' or '{secondNumber}' is in exeption (> 1000 or < -1000");

        }
    }
}
