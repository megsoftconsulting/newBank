
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace NewBankMobile.Droid
{
	[Activity (Label = "LoginScreen",MainLauncher = true)]			
	public class LoginScreen : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.LoginScreen);

			DecorateWindow();
		}

		void DecorateWindow ()
		{
			ActionBar.Hide();

			Window.ClearFlags(WindowManagerFlags.Fullscreen);
		}
	}
}

