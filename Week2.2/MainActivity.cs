using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Util;

namespace Week2._2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        int _counter = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            //int _counter = 0;

            if (savedInstanceState != null)
            {
                _counter = savedInstanceState.GetInt("click_count", 0); Log.Debug(GetType().FullName, "Activity A - Recovered instance state");
            }

            var clickbutton = FindViewById<Button>(Resource.Id.clickButton);
            clickbutton.Text = $"Clicked {_counter} times"; clickbutton.Click += (object sender, System.EventArgs e) =>
            {
                _counter++;

                clickbutton.Text = $"Clicked {_counter} times";
            };


        }

        protected override void OnSaveInstanceState(Bundle outState)
        {
            outState.PutInt("click_count", _counter);
            Log.Debug(GetType().FullName, "Activity A - Saving instance state");

            // always call the base implementation!
            base.OnSaveInstanceState (outState);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

        

    }
}