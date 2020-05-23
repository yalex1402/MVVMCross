using MvvmCross.IoC;
using MvvmCross.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using TipCalculator.Core.ViewModels;

namespace TipCalculator.Core
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

            RegisterAppStart<TipViewModel>();
        }
    }
}
