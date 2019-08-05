using Foundation;
using System;
using System.Collections.Generic;
using UIKit;

namespace Week3
{
    public partial class ViewController : UIViewController

    {

        public List<StudentInfo> allStudents { get; set; }


        public ViewController(IntPtr handle) : base(handle)

        {

            allStudents = new List<StudentInfo>();

        }


        public override void ViewDidLoad()

        {

            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.


            saveButton.TouchUpInside += (object sender, EventArgs e) => {
                StudentInfo newStudent = new StudentInfo(nameText.Text,idText.Text);

                allStudents.Add(newStudent);


                string infoString = "Name: " + newStudent.name + " ID: " + newStudent.id;

                var alert = UIAlertController.Create("New Student Information", infoString, UIAlertControllerStyle.Alert);
                alert.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));

                PresentViewController(alert, true, null);

            };

        }


        public override void DidReceiveMemoryWarning()

        {

            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.

        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender)

        {

            base.PrepareForSegue(segue, sender);

            var allStudentInfoController = segue.DestinationViewController as ShowAllInfoController;

            if (allStudentInfoController != null)

            {

                allStudentInfoController.allStudents = allStudents;

            }

        }


    }

}