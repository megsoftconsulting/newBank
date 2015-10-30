using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;

namespace NewBankMobile.Droid.Adapters
{
    public class TransactionAdapter : BaseAdapter<Transaction>
    {
        private readonly Activity _context;
        private readonly IList<Transaction> _transactions;

        public TransactionAdapter(Activity context, IList<Transaction> txs)
        {
            _context = context;
            _transactions = txs;
        }

        #region implemented abstract members of BaseAdapter

        public override Transaction this[int index]
        {
            get { return _transactions[index]; }
        }


        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var model = this[position];

            var view = convertView ?? _context
                .LayoutInflater
                .Inflate(Android.Resource.Layout.SimpleListItem1, null);

            view.FindViewById<TextView>(Android.Resource.Id.Text1).Text = "Bind me to my data";

            return view;
        }

        public override int Count
        {
            get { return _transactions.Count; }
        }

        #endregion
    }
}