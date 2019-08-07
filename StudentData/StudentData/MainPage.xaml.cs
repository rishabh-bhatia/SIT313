using System;

using System.ComponentModel;
using Xamarin.Forms;

namespace StudentData

{

    [DesignTimeVisible(false)]

    public partial class MainPage : ContentPage

    {

        public MainPage()

        {

            InitializeComponent();

        }

        async void btnEnterClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new EnterInformation

            {

                BindingContext = new StudentInfo()

            });

        }

        async void btnShowAllClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new ShowAllInformation { });

        }

    }

}
