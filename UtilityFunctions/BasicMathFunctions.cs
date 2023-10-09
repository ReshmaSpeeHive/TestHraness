using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilityFunctions
{
    [Information(Description = "This class contains basic math functionality")]
    public class BasicMathFunctions
    {
        [Information(Description = "This method divides the first number by the second number and returns a result of this divide operation")]
        public double DivideOperation(double number1, double number2)
        {
            return number1 / number2;
        }
        [Information(Description = "This method multiplies the first number by the second number and returns a result of this multiplication operation")]
        public double MultiplyOperation(double number1, double number2)
        {
            return number1 * number2;
        }
    }
}
