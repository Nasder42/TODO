using System;
using System.Collections.Generic;
using TODO.Data;
using TODO.Models;
using Xamarin.Forms;

namespace TODO.Views
{
    public partial class ArchivedTodoPage : ContentPage
    {

        public ArchivedTodoPage()
        {
            InitializeComponent();
            BindingContext = new CompletedTodoVM { Todos = GoalsDB.GetCompleted() };
            completedList.ItemsSource = GoalsDB.GetCompleted();
            completedList.ItemTemplate = new DataTemplate(typeof(TextCell)); // has context actions defined
            completedList.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            completedList.ItemTemplate.SetBinding(TextCell.DetailProperty, "Text");
        }
    }
}
