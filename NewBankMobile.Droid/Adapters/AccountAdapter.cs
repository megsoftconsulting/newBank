using System;
using NewBankMobile.Models;
using Android.Widget;
using Android.Views;
using Android.App;
using System.Collections.Generic;

namespace NewBankMobile.Droid
{
    public class AccountAdapter : BaseAdapter<Account>
    {
        readonly Activity _context;
        IList<Account> _accounts;

        public AccountAdapter(Activity context, IList<Account> accounts)
        {
            _context = context;
            _accounts = accounts;
        }


        public void SetAccount(IList<Account> accounts)
        {
            _accounts = accounts;
            NotifyDataSetChanged();
        }

        #region implemented abstract members of BaseAdapter

        public override long GetItemId(int position)
        {
            return this[position].Id;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {

            var model = this[position];

            var view = convertView ?? _context.LayoutInflater.Inflate(Resource.Layout.DebitListViewItemLayout, null);

            var accountName = view.FindViewById<TextView>(Resource.Id.accountName);
            var accountGroup = view.FindViewById<TextView>(Resource.Id.accountTypeLabel);
            var accountAmount = view.FindViewById<TextView>(Resource.Id.accountAmount);

            accountName.Text = model.Name;
            accountGroup.Text = model.AccountType.ToString();
            accountAmount.Text = model.CurrentBalance.ToString("C");

            return view;
        }

        public override int Count
        {
            get
            {
                return _accounts.Count;
            }
        }

        #endregion

        #region implemented abstract members of BaseAdapter

        public override Account this[int index]
        {
            get
            {
                return _accounts[index];
            }
        }

        #endregion
    }
}

