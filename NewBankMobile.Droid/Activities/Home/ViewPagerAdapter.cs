using System;
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
using NewBankMobile.Droid.Fragments;
using Java.Lang;
using Android.Content;

namespace NewBankMobile.Droid
{
	public class ViewPagerAdapter : FragmentPagerAdapter
	{
		Context _context;

		string[] _tabsTitle;

		public override int Count {
			get {
				return 3;
			}
		}

		public ViewPagerAdapter (Context context, FragmentManager fragmentManagerSupport):
			base(fragmentManagerSupport)
		{
			_context = context;

			InitTitles();
		}

		void InitTitles ()
		{
			_tabsTitle = _context.Resources.GetStringArray(Resource.Array.HomeTitles);
		}

		public override Fragment GetItem (int position)
		{
			switch(position)
			{
			case 0:
				{
					return new AccountFragment();
				}
			case 1:
				{
					return new MoneyTransferFragment();
				}
			case 2:
				{
					return new PaymentFragment();
				}
			default:
				return new Fragment();
			}
		}

//		public override ICharSequence GetPageTitleFormatted (int position)
//		{
//			var title = _tabsTitle[position];
//
//			return new Java.Lang.String(title);
//		}
	}
}