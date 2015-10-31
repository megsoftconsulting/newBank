using Android.App;
using Android.OS;
using Android.Support.V4.Widget;
using Android.Views;
using Android.Support.Design.Widget;
using Android.Support.V7.Widget;
using Android.Support.V7.App;

namespace NewBankMobile.Droid
{
	//No MVVM SO FAR
	[Activity(Theme="@style/MyTheme.Base")]
	public class Home : AppCompatActivity
	{
		DrawerLayout _drawerLayout;

		Toolbar _toolbar;

		NavigationView _navigationView;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Home);

			SetReferences();

            ConfigToolBar();
		}

		void SetReferences ()
		{
			_toolbar = FindViewById<Toolbar> (Resource.Id.my_awesome_toolbar);

			_drawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);

			_navigationView = FindViewById<NavigationView> (Resource.Id.nav_view);
		}

		void ConfigToolBar ()
		{
			SetSupportActionBar (_toolbar);

			SupportActionBar.SetHomeAsUpIndicator (Resource.Drawable.ic_home_icono_burger);

			SupportActionBar.SetDisplayHomeAsUpEnabled (true);

			_navigationView.NavigationItemSelected+= OnNavigationItemSelected;
		}

		void OnNavigationItemSelected (object sender, NavigationView.NavigationItemSelectedEventArgs e)
		{
			e.MenuItem.SetChecked (true);

			_drawerLayout.CloseDrawers ();
		}

		public override bool OnOptionsItemSelected (IMenuItem item) 
		{
			switch (item.ItemId) 
			{
			case Android.Resource.Id.Home:
				_drawerLayout.OpenDrawer (Android.Support.V4.View.GravityCompat.Start);
				return true;
			}
			return base.OnOptionsItemSelected (item);
		}
	}
}

