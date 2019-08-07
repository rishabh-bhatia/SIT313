using System;
using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace StudentData

{

    public partial class ShowAllInformation : ContentPage

    {

        public ShowAllInformation()

        {

            InitializeComponent();

        }

        protected override void OnAppearing() //load the data in listview

        {

            base.OnAppearing();

            List<StudentInfo> allInfo = new List<StudentInfo>();//this will be the data source for list view

            var files = Directory.EnumerateFiles(App.FolderPath, "*.Info.txt");//get files for all students
            foreach (var filename in files)
            {

                StudentInfo student = new StudentInfo(); //get each studentInfo object
                student.Filename = filename;
                string str = File.ReadAllText(filename);// read the information
                string[] splitStr = str.Split(' ');//tokenize the data
                student.ID = splitStr[0];

                //generate the allmarks string for listview

                student.allmarks = "SIT313: " + splitStr[1] + " SIT314: " + splitStr[2] + " SIT446: " + splitStr[3]; allInfo.Add(student);
            }

            listView.ItemsSource = allInfo.ToArray(); //specify the data source

        }

        async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)

        {

            if (e.SelectedItem != null)

            {

                StudentInfo s = e.SelectedItem as StudentInfo;

                //now split the data to fill out the StudentInfo object

                string[] str = s.allmarks.Split(' ');

                s.marksIn313 = str[1];

                s.marksIn314 = str[3];

                s.marksIn446 = str[5];

                await Navigation.PushAsync(new EnterInformation

                {

                    BindingContext = s //specify the binding context

                });

            }

        }

    }

}
