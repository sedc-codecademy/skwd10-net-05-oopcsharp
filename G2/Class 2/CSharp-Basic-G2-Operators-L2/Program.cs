using System;

namespace CSharp_Basic_G2_Operators_L2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare two integer variables with values
            int variableOne = 1;
            int variableTwo = 2;

            // Perform the operation addition and store the result in a third variable
            int result = variableOne + variableTwo;

            // Print out the result of the addition
            Console.WriteLine(result);
            // Example of addition without assinging the result to a variable
            Console.WriteLine(variableOne + variableTwo);

            // Declare two decimal variables and assign values
            decimal decimalVariableOne = 1.5m;
            decimal decimalVariableTwo = 2.5m;

            // Perform the operations subtraction and store the result in a third variable
            decimal decimalResult = decimalVariableOne - decimalVariableTwo;
            decimal decimalResultMultiplication = decimalVariableOne * decimalVariableTwo;
            decimal decimalResultDivision = decimalVariableOne / decimalVariableTwo;

            // Print out the result
            Console.WriteLine(decimalResult);
            Console.WriteLine(decimalResultMultiplication);
            Console.WriteLine(decimalResultDivision);

            bool boolVariableOne = false;
            bool boolVariableTwo = false;

            bool boolResult = (!boolVariableOne && boolVariableTwo) || true;

            Console.WriteLine(boolResult);

            // Boolean cases
            // a = true && b = true => true
            // a = true && b = false => false
            // a = false && b = true => false
            // a = false && b = false => false

            // a = true || b = true => true
            // a = true || b = false => true
            // a = false || b = true => true
            // a = false || b = false => false
        }
    }
}
