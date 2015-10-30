using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using Android.Graphics;

namespace NewBankMobile.Droid.Adapters
{
    public class TransactionAdapter : BaseAdapter<Transaction>
    {
        readonly Activity _context;
        IList<Transaction> _transactions;

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
                .Inflate(Resource.Layout.TransactionListViewItem, null);

            var transactionDescriptionTextView = view.FindViewById<TextView>(Resource.Id.transactionDescription);
            var transactionDateTextView = view.FindViewById<TextView>(Resource.Id.transactionDate);
            var transactionAmountTextView = view.FindViewById<TextView>(Resource.Id.transactionAmount);

            transactionDescriptionTextView.Text = model.Description;
            transactionDateTextView.Text = model.Date.ToString("D");
            transactionAmountTextView.Text = model.Amount.ToString("C");

            transactionAmountTextView.SetTextColor(model.Category == "Debit" ? Color.ParseColor("#FF6666") : Color.ParseColor("#00C13A"));

            return view;
        }

        public override int Count
        {
            get { return _transactions.Count; }
        }


        public void FillTransactions(IList<Transaction> trxs)
        {
            _transactions = trxs;
            NotifyDataSetChanged();
        }

        #endregion
    }
}