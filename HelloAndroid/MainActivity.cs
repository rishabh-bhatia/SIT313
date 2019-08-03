using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace HelloAndroid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            var imageButton = FindViewById<ImageButton>(Resource.Id.imageButton1);
            var imageSwitch = false;
            imageButton.Click += delegate {
	
                if(imageSwitch)
                {
                    imageButton.SetImageResource(Resource.Drawable.image1);
                    imageSwitch = false;
                }

                else
                {
                    imageButton.SetImageResource(Resource.Drawable.image2);
                    imageSwitch = true;
                }
	};
        }

    }
}

