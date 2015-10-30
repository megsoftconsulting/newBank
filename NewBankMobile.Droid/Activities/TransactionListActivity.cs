

using Android.App;
using Android.OS;
using Android.Widget;
using NewBankMobile.Droid.Adapters;
using System.Collections.Generic;
using NewBankMobile.Interfaces;
using NewBankMobile.Repositories;
using System.Threading.Tasks;

namespace NewBankMobile.Droid.Activities
{
    [Activity(Label = "Transaction List", Icon="@drawable/ic_home_logo_banco")]
    public class TransactionListActivity : Activity
    {
        ListView _listView;

        TransactionAdapter _adapter;
        ITransactionRepository _repository;

        List<Transaction> _transactions;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.TransactionList);

            Init();

            SetReferences();

        }

        protected override async void OnResume()
        {
            base.OnResume();

            var accountId = Intent.GetLongExtra("ACCOUNT_ID", 0);

            _transactions = await GetTransactions(accountId);

            _adapter.FillTransactions(_transactions);
        }

        void Init()
        {
            _repository = new TransactionRepository();

            _transactions = new List<Transaction>();

            _adapter = new TransactionAdapter(this, _transactions);
        }

        void SetReferences()
        {

            _listView = FindViewById<ListView>(Resource.Id.transactionsList);
            _listView.Adapter = _adapter;
        }

        async Task<List<Transaction>> GetTransactions(long accId)
        {
            return await _repository.ListAllByAccountAsync(accId);
        }
    }
}

