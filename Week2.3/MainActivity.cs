using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;


namespace Week2._3
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        static readonly List<string> studentNames = new List<string>();
        static readonly List<string> studentIDs = new List<string>();
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button viewAllButton = FindViewById<Button>(Resource.Id.ViewAllButton);
            Button saveButton = FindViewById<Button>(Resource.Id.SaveButton);
            TextView name = FindViewById<EditText>(Resource.Id.nameText);
            TextView id = FindViewById<EditText>(Resource.Id.idText);

            viewAllButton.Click += (sender, e) =>

            {

                var intent = new Intent(this, typeof(Week2._3.ViewAllActivity));
                intent.PutStringArrayListExtra("student_name", studentNames);
                intent.PutStringArrayListExtra("student_id", studentIDs);
                StartActivity(intent);
            };

            saveButton.Click += (sender, e) =>

            {

                string newName = ""; string newID = "";
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(id.Text))

                {

                    newName = ""; newID = "";

                }

                else

                {

                    studentNames.Add(name.Text); studentIDs.Add(id.Text);
                }

            };

        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}