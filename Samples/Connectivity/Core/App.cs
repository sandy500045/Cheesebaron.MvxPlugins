﻿using MvvmCross.Core.ViewModels;
using Core.ViewModels;

namespace Core
{
    public class App 
        : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<TestViewModel>();
        }
    }
}
