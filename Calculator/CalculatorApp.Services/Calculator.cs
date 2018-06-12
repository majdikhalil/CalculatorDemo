using System;

namespace CalculatorApp.Services
{
    public class Calculator
    {
        public int Add(int num1, int num2)
        {
            var result = num1 + num2;

            return result; 
        }

        public int Subtract(int num1, int num2)
        {
            var result = num1 - num2; 
            return result;
        }

        public int Divide(int num1, int num2)
        {
            var result = num1 / num2;
            return result;
        }

        
    }
}
