using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Services
{
    public class CalculatorService : ICalculatorService
    {
        public int Div(int firstNumber, int secondNumber)
        {
            try
            {
                return firstNumber / secondNumber;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public double Div(double firstNumber, double secondNumber)
        {
            try
            {
                return firstNumber / secondNumber;
            }
            catch (DivideByZeroException)
            {
                return 0;
            }
        }

        public int Mult(int firstNumber, int secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public double Mult(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }

        public int Subs(int firstNumber, int secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public double Subs(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }

        public int Sum(int firstNumber, int secondNumber)
        {
            return firstNumber + secondNumber;
        }

        public double Sum(double firstNumber, double secondNumber)
        {
            return firstNumber + secondNumber;
        }
    }
}
