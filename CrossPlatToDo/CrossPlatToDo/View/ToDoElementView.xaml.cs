using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CrossPlatToDo
{
    public partial class ToDoElementView : ContentPage
    {
        public ToDoElementView()
        {
            InitializeComponent();
        }

        //When SAVE Button is pressed, this function is called to save the data inside our database
        async void OnSave(object sender, EventArgs e)
        {
            var toDoElement = (ToDoElement)BindingContext;
            await App.Database.SaveElement(toDoElement);
            await Navigation.PopAsync();
        }
        //When DELETE Button is pressed, this function is called to delete the data inside our database
        async void OnDelete(object sender, EventArgs e)
        {
            var toDoElement = (ToDoElement)BindingContext;
            await App.Database.DeleteElement(toDoElement);
            await Navigation.PopAsync();
        }
        //When CANCEL Button is pressed, this function is called to cancel any changes made and go back inside our database
        async void OnCancel(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
