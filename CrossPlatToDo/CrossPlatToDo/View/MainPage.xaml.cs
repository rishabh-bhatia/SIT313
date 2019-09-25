using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CrossPlatToDo
{
    
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        //this function is caled when the page is being created or between navigation between different pages
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            listView.ItemsSource = await App.Database.GetElements();
        }
        //This function is called when an Item is added to the database so we update the listview on our page
        async void AddElement(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ToDoElementView
            {
                BindingContext = new ToDoElement()
            });
        }
        /*This function is called when we click on a particular element in the list and
         * takes us to that element's page
         * for modification or deletion
         */
        async void GetElementInList(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new ToDoElementView
                {
                    BindingContext = e.SelectedItem as ToDoElement
                });
            }
        }
    }
}
