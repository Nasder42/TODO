using System;
using System.Collections.Generic;
using TODO.Data;
using TODO.Models;
using Xamarin.Forms;

namespace TODO.Views
{
    public partial class FutureTodoPage : ContentPage
    {
        public FutureTodoPage()
        {
            InitializeComponent();
            BindingContext = new FutureTodoVM { Todos = GoalsDB.GetFuture() };
            futureList.ItemsSource = GoalsDB.GetFuture();
            futureList.ItemTemplate = new DataTemplate(typeof(TextCell)); // has context actions defined
            futureList.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            futureList.ItemTemplate.SetBinding(TextCell.DetailProperty, "Text");
        }
    }
}
