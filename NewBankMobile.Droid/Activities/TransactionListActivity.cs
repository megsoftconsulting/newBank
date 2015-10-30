

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
    [Activity(Label = "TransactionListActivity")]			
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

            _transactions = await GetTransactions(1);

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

