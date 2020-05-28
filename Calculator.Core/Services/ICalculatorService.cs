using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core.Services
{
    public interface ICalculatorService
    {
        int Sum(int firstNumber, int secondNumber);

        int Subs(int firstNumber, int secondNumber);

        int Mult(int firstNumber, int secondNumber);

        int Div(int firstNumber, int secondNumber);

        double Sum(double firstNumber, double secondNumber);

        double Subs(double firstNumber, double secondNumber);

        double Mult(double firstNumber, double secondNumber);

        double Div(double firstNumber, double secondNumber);
    }
}
