using Calculator.Core.ViewModels;
using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            //Inject all things that ends like Service
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<CalculatorViewModel>();
        }
    }
}
