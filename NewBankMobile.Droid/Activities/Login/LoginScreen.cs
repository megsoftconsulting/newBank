
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
using Android.Support.V7.App;

namespace NewBankMobile.Droid
{
	[Activity (Label = "NewBankMobile", MainLauncher = true, Theme="@style/Theme.AppCompat")]			
	public class LoginScreen : AppCompatActivity
	{
		Button _loginButton;

		EditText _userName;

		EditText _password;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView(Resource.Layout.LoginScreen);

			SetViewReferences();

			DecorateWindow();
		}

		void SetViewReferences ()
		{
			_loginButton = FindViewById<Button>(Resource.Id.loginButton);

			_userName = FindViewById<EditText>(Resource.Id.userName);

			_password = FindViewById<EditText>(Resource.Id.password);

//			_loginButton.SetBinding

			_loginButton.Click += OnLoginButtonClick;
		}

		void OnLoginButtonClick (object sender, EventArgs e)
		{
			StartActivity(typeof(Home));
		}

		void DecorateWindow ()
		{
//			ActionBar.Hide();

			Window.ClearFlags(WindowManagerFlags.Fullscreen);
		}
	}
}

