using System;

using System.Collections.Generic;
using System.IO;
using Xamarin.Forms;

namespace StudentData

{

    public partial class EnterInformation : ContentPage

    {

        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Info.txt");

        public EnterInformation()

        {

            InitializeComponent();

        }

        async void OnSaveButtonClicked(object sender, EventArgs e)

        {

            //get the binding context.

            var studentInfo = (StudentInfo)BindingContext;

            if (string.IsNullOrWhiteSpace(studentInfo.Filename))//if it is a new student

            {

                var fileName = Path.Combine(App.FolderPath, $"{Path.GetRandomFileName()}.Info.txt"); //create a new file for new student
                studentInfo.Filename = fileName; //save the file path
                File.WriteAllText(fileName, studentInfo.ToString()); //write information
            }

            else //if we are updating student info

            {

                File.WriteAllText(studentInfo.Filename, studentInfo.ToString());

            }

            await Navigation.PopAsync();

        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)

        {

            var studentInfo = (StudentInfo)BindingContext; //get the binding context
            if (File.Exists(studentInfo.Filename)) //check if data exists
            {

                File.Delete(studentInfo.Filename); //delete file

            }

            await Navigation.PopAsync();

        }

    }

}
