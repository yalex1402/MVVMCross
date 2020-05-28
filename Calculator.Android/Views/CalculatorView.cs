﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Calculator.Core.ViewModels;
using MvvmCross.Platforms.Android.Views;

namespace Calculator.Android.Views
{
	[Activity(Label = "@string/app_name")]
	public class FactorialView : MvxActivity<CalculatorViewModel>
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.CalculatorPage);
		}
	}
}