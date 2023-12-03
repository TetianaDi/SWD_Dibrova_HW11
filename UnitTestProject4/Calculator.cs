using System;

namespace UnitTestProject4
{
    internal class Calculator
    {
        public static int MultiplyTwoNumbers(int firstNumber, int secondNumber)
        {
            VerifyNumbers(firstNumber);
            VerifyNumbers(secondNumber);

            return firstNumber * secondNumber;
        }

        public static bool VerifyNumbers(int number)
        {
            {
                if (number < -1000 || number > 1000)
                {
                    throw new Exception ($"You must specify numbers between -1000 and 1000");
                }
                    return true;
            }

        }
    }
}
