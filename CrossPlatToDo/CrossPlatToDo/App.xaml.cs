using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CrossPlatToDo
{
    public partial class App : Application
    {
        static ToDoDatabase database;
        //Setting the mainpage of the app as mainpage
        public App()
        {
            var nav = new NavigationPage(new MainPage());
            MainPage = nav;
        }
        //Initializing the database
        public static ToDoDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database = new ToDoDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3"));
                }
                return database;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
