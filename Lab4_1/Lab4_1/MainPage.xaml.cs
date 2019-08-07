using System;
using System.IO;
using System.ComponentModel;
using Xamarin.Forms;

namespace Lab4_1

{

    [DesignTimeVisible(false)]

    public partial class MainPage : ContentPage

    {

        //path to save information
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Info.txt");
        public MainPage()
        {

            InitializeComponent();

        }

        //event listner for Save button

        async void OnSaveButtonClicked(object sender, EventArgs e)

        {

            StudentInfo thisStudent = new StudentInfo();
            thisStudent.ID = txtID.Text;
            thisStudent.marksIn313 = txt313.Text;
            thisStudent.marksIn314 = txt314.Text;
            thisStudent.marksIn446 = txt446.Text;
            File.WriteAllText(_fileName, thisStudent.ToString());

        }

        //event listner for Delete button

        async void OnDeleteButtonClicked(object sender, EventArgs e)

        {

            if (File.Exists(_fileName))//check if the file exists
            {

                File.Delete(_fileName);

                txtID.Text = "";//clear all fields

                txt313.Text = "";

                txt314.Text = "";

                txt446.Text = "";
            }
        }
    }

}
