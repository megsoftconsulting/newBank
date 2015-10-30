
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using NewBankMobile.Droid.Fragments;
using NewBankMobile.Repositories;
using NewBankMobile.Interfaces;

namespace NewBankMobile.Droid
{
    [Activity(Label = "New Bank Mobile", Icon="@drawable/ic_home_logo_banco")]
    public class HomeActivity : Activity
    {
        IAccountRepository _accountRepository;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            _accountRepository = new AccountRepository();
            var fragment = new AccountFragment(_accountRepository);

            FragmentManager.BeginTransaction().Add(Android.Resource.Id.Content, fragment).Commit();
        }
    }
}

