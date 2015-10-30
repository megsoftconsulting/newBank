using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.App;
using Android.Support.V4.Widget;
using Android;
using Android.Views;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Android.Support.V7.App;
using Android.Graphics;

namespace NewBankMobile.Droid
{
	//No MVVM SO FAR
	[Activity(Theme="@style/MyTheme.Base")]
	public class Home : AppCompatActivity
	{
		DrawerLayout drawerLayout;

		NavigationView navigationView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Home);

			var toolbar = FindViewById<Toolbar>(Resource.Id.my_awesome_toolbar);

//			toolbar.SetTitleTextColor(2232);

			SetSupportActionBar (toolbar);

			SupportActionBar.SetHomeAsUpIndicator (Resource.Drawable.ic_home_icono_burger);

			SupportActionBar.SetDisplayHomeAsUpEnabled (true);

			drawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);

			navigationView = FindViewById<NavigationView> (Resource.Id.nav_view);

			navigationView.NavigationItemSelected+= OnNavigationItemSelected;
		}

		void OnNavigationItemSelected (object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			e.MenuItem.SetChecked (true);

			drawerLayout.CloseDrawers ();
		}

		public override bool OnOptionsItemSelected (IMenuItem item) 
		{
			switch (item.ItemId) 
			{
			case Android.Resource.Id.Home:
				drawerLayout.OpenDrawer (Android.Support.V4.View.GravityCompat.Start);
				return true;
			}
			return base.OnOptionsItemSelected (item);
		}
	}
}

