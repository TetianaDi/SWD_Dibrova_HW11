using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject4
{
    internal class Exeption
    {
        public static Task<Exeption> NumbersAsync(int firstNumber, int secondNumber)
        {
            if (firstNumber > -1000 || firstNumber > 1000)
            {
                throw new ArgumentException(
                    "You must specify numbers between -1000 and 1000.",
                    nameof(firstNumber));
            }

            if (firstNumber > -1000 || firstNumber > 1000)
            {
                throw new ArgumentException(
                    "You must specify numbers between -1000 and 1000.",
                    nameof(firstNumber));

            }
            return NumbersAsync(firstNumber, secondNumber);
        }

    }
}
