﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExamApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InfoPage : ContentPage
	{
		private string _login;
		public InfoPage (string login)
		{
			_login = login;
			InitializeComponent ();
		}

	}
}