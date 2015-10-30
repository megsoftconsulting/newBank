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
using Android.Support.V4.View;

namespace NewBankMobile.Droid
{
	[Activity(Theme="@style/MyTheme.Base")]
	public class Home : AppCompatActivity
	{
		DrawerLayout _drawerLayout;

		Toolbar _toolbar;

		NavigationView _navigationView;

		ViewPager _pager;

		ViewPagerAdapter _pagerAdapter;

		TabLayout _tabLayout;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Home);

			InitReferences();

			InitToolbar();

			InitPager();
		}

		void InitPager ()
		{
			_pagerAdapter = new ViewPagerAdapter(BaseContext, SupportFragmentManager);

			_pager.Adapter = _pagerAdapter;
		}

		void InitReferences ()
		{
			_toolbar = FindViewById<Toolbar> (Resource.Id.toolbar_home);

			_drawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);

			_navigationView = FindViewById<NavigationView> (Resource.Id.nav_view);

			_pager = FindViewById<ViewPager>(Resource.Id.viewpager);

			_tabLayout = FindViewById<TabLayout>(Resource.Id.tablayout);
		}

		void InitToolbar ()
		{
			SetSupportActionBar (_toolbar);

			SupportActionBar.SetHomeAsUpIndicator (Resource.Drawable.ic_home_icono_burger);

			SupportActionBar.SetDisplayHomeAsUpEnabled (true);

			CreateTabs();

			_navigationView.NavigationItemSelected+= OnNavigationItemSelected;
		}

		void CreateTabs()
		{
			var toolbarItem1 = _tabLayout.NewTab().SetText("Test 0");

			var toolbarItem2 = _tabLayout.NewTab().SetText("Test 1");

			var toolbarItem3 = _tabLayout.NewTab().SetText("Test 2");

			_tabLayout.AddTab(toolbarItem1);

			_tabLayout.AddTab(toolbarItem2);

			_tabLayout.AddTab(toolbarItem3);
		}

		void OnNavigationItemSelected (object sender, NavigationView.NavigationItemSelectedEventArgs drawerItemSelected)
		{
			drawerItemSelected.MenuItem.SetChecked (true);

			_drawerLayout.CloseDrawers ();
		}

		public override bool OnOptionsItemSelected (IMenuItem toolBarItem) 
		{
			switch (toolBarItem.ItemId)
			{
			case Android.Resource.Id.Home:
				
				_drawerLayout.OpenDrawer (Android.Support.V4.View.GravityCompat.Start);

				return true;
			}

			return base.OnOptionsItemSelected (toolBarItem);
		}

		protected override void Dispose (bool disposing)
		{
			if(disposing)
			{
				_navigationView.NavigationItemSelected -= OnNavigationItemSelected;
			}

			base.Dispose (disposing);
		}
	}
}

