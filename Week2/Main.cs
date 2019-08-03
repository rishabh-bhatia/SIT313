
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace Week2
{
    [Activity(Label = "Main", MainLauncher = true)]
    public class Main : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.main);

            Log.Debug("Lab2", "Activity A - OnCreate");
            // Create your application here
        }

        protected override void OnDestroy()
        {
            Log.Debug("Lab2", "Activity A - On Destroy"); base.OnDestroy();
        }

        protected override void OnPause()
        {
            Log.Debug("Lab2", "Activity A - OnPause"); base.OnPause();
        }

        protected override void OnRestart()
        {
            Log.Debug("Lab2", "Activity A - OnRestart"); base.OnRestart();
        }

        protected override void OnResume()
        {
            Log.Debug("Lab2", "Activity A - OnResume"); base.OnResume();
        }

        protected override void OnStart()
        {
            Log.Debug("Lab2", "Activity A - OnStart"); base.OnStart();
        }

        protected override void OnStop()

        {
            Log.Debug("Lab2", "Activity A - OnStop"); base.OnStop();
        }

    }
}
