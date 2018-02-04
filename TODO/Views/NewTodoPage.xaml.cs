using System;
using System.Collections.Generic;
using Xamarin.Forms;
using TODO.Data;
using TODO.Models;


namespace TODO.Views
{
    public partial class NewTodoPage : ContentPage
    {

        public NewTodoPage()
        {
            InitializeComponent();
        }


        async void AddNewTodo(object sender, EventArgs e)
        {
            //TODO.Views.
            //string title = titleEntry.Text();
            Goal item = new Goal
            {
                Title = titleEntry.Text,
                Text = textEntry.Text,
                DatePlanned = datePlannedPicker.Date
            };

            //Todo: Make new TodoItem Object and save it to db.
            GoalsDB.AddTodo(item);
            await Navigation.PopAsync();
        }
    }
}
