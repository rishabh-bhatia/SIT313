using System;
using System.Collections.Generic;
using Android.App;
using Android.OS;
using Android.Widget;
namespace Week2._3
{
    [Activity(Label = "View All Students")]
    public class ViewAllActivity : ListActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            // Create your application here
            var studentNames = Intent.Extras.GetStringArrayList("student_name") ?? new string[0];
            var studentIDs = Intent.Extras.GetStringArrayList("student_id") ?? new string[0]; this.ListAdapter = new ArrayAdapter<string>(this,
            Android.Resource.Layout.SimpleListItem1, studentNames);
        }
    }
}
