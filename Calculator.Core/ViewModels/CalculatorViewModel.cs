using Calculator.Core.Services;
using MvvmCross.Commands;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Calculator.Core.ViewModels
{
    public class CalculatorViewModel: MvxViewModel
    {
        private readonly ICalculatorService _calculatorService;
        private double _firstNumber;
        private double _secondNumber;
        private double _result;
        private MvxCommand _sumCommand;
        private MvxCommand _subsCommand;
        private MvxCommand _multCommand;
        private MvxCommand _divCommand;

        public CalculatorViewModel(ICalculatorService calculatorService)
        {
            _calculatorService = calculatorService;
        }

        public double FirstNumber
        {
            get => _firstNumber;
            set => SetProperty(ref _firstNumber, value);
        }

        public double SecondNumber
        {
            get => _secondNumber;
            set => SetProperty(ref _secondNumber, value);
        }

        public double Result
        {
            get => _result;
            set => SetProperty(ref _result, value);
        }

        public ICommand SumCommand
        {
            get
            {
                _sumCommand = _sumCommand ?? new MvxCommand(Sum);
                return _sumCommand;
            }
        }

        public ICommand SubsCommand
        {
            get
            {
                _subsCommand = _subsCommand ?? new MvxCommand(Substract);
                return _subsCommand;
            }
        }

        public ICommand MultCommand
        {
            get
            {
                _multCommand = _multCommand ?? new MvxCommand(Multiply);
                return _multCommand;
            }
        }

        public ICommand DivCommand
        {
            get
            {
                _divCommand = _divCommand ?? new MvxCommand(Divide);
                return _divCommand;
            }
        }

        public override async Task Initialize()
        {
            await base.Initialize();
            FirstNumber = 0;
            SecondNumber = 0;
            Sum();
        }

        private void Sum()
        {
            Result = _calculatorService.Sum(FirstNumber, SecondNumber);
        }

        private void Substract()
        {
            Result = _calculatorService.Subs(FirstNumber, SecondNumber);
        }

        private void Multiply()
        {
            Result = _calculatorService.Mult(FirstNumber, SecondNumber);
        }

        private void Divide()
        {
            Result = _calculatorService.Div(FirstNumber, SecondNumber);
        }
    }
}
