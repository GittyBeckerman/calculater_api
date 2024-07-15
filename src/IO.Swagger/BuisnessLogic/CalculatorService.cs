using System;

namespace IO.Swagger.BuisnessLogic
{
    //this class is contain the main service that do all the logic
    public class CalculatorService : ICalculatorService
    {
        //execute function is commen function that calculate 
        public int Execute(int number1, int number2, string operation)
        {

            //find the appropriate function by operration field. and call it.
            return operation.ToLower() switch
            {
                "add" => Add(number1, number2),
                "subtract" => Subtract(number1, number2),
                "multiply" => Multiply(number1, number2),
                "divide" => Divide(number1, number2),
                _ => throw new InvalidOperationException("Invalid operation"),
            };
        }

        private int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        private int Subtract(int number1, int      number2)
        {
            return number1 - number2;
        }

        private int Multiply(int number1, int  number2)
        {
            return number1 * number2;
        }

        private int Divide(int number1, int number2)
        {
            if (number2 == 0)
            {
                throw new DivideByZeroException("Cannot divide by zero");
            }
            return number1 / number2;
        }
    }

}
