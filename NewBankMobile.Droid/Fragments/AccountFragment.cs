
using System.Collections.Generic;
using System.Linq;

using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using NewBankMobile.Interfaces;
using NewBankMobile.Models;
using Android.Content;
using NewBankMobile.Droid.Activities;

namespace NewBankMobile.Droid.Fragments
{
    public class AccountFragment : Fragment
    {
        ListView _accountDebitListView;

        ListView _accountCreditListView;

        AccountAdapter _debitAdapter, _creditAdapter;

        IList<Account> _debit;

        IList<Account> _credit;

        readonly IAccountRepository _accountRepository;

        public AccountFragment(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {

            var view = inflater.Inflate(Resource.Layout.AccountFragment, null);

            _accountDebitListView = view.FindViewById<ListView>(Resource.Id.accountDebitListView);
            _accountCreditListView = view.FindViewById<ListView>(Resource.Id.accountCreditListView);

            _accountDebitListView.ItemClick += _accountSelected;
            _accountCreditListView.ItemClick += _accountSelected;

            _debit = new List<Account>();
            _credit = new List<Account>();

            _debitAdapter = new AccountAdapter(Activity, _debit);
            _creditAdapter = new AccountAdapter(Activity, _credit);

            _accountDebitListView.Adapter = _debitAdapter;
            _accountCreditListView.Adapter = _creditAdapter;

            return view;
        }


        void _accountSelected (object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(Activity, typeof(TransactionListActivity));

            intent.PutExtra("ACCOUNT_ID", e.Id);

            StartActivity(intent);
        }


        public override async void OnViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);

            var data = await _accountRepository.GetByUserIdAsync(1);

            _debit = data.Where(a => a.AccountType == AccountType.Debit).ToList();

            _credit = data.Where(a => a.AccountType == AccountType.Credit).ToList();

            _debitAdapter.SetAccount(_debit);
            _creditAdapter.SetAccount(_credit);
        }
    }
}

