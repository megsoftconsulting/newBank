﻿
using System;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using Android.Support.V7.App;
using NewBankMobile.Droid.Activities;

namespace NewBankMobile.Droid
{
    [Activity (Label = "LoginScreen",MainLauncher = true, Theme="@style/MyTheme", NoHistory=true)]			
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

			_loginButton.Click += OnLoginButtonClick;
		}

		void OnLoginButtonClick (object sender, EventArgs e)
		{
			StartActivity(typeof(HomeActivity));
		}

		void DecorateWindow ()
		{
			Window.ClearFlags(WindowManagerFlags.Fullscreen);
		}
	}
}

