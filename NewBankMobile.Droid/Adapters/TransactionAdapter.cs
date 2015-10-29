using System;
using Android.Widget;
using Android.Views;

namespace NewBankMobile.Droid.Adapters
{
    public class TransactionAdapter : BaseAdapter<Transaction>
    {
        public TransactionAdapter()
        {
            
        }

        #region implemented abstract members of BaseAdapter

        public override long GetItemId(int position)
        {
            throw new NotImplementedException();
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            throw new NotImplementedException();
        }

        public override int Count
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion

        #region implemented abstract members of BaseAdapter

        public override Transaction this[int index]
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        #endregion
    }
}

