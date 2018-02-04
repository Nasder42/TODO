using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using TODO.Data;
using TODO.Models;
using Xamarin.Forms;

namespace TODO.Views
{
    public partial class TestPage : ContentPage
    {
        private readonly GoalsPreviewVM _goalsPreviewList;
        private List<Goal> _listGoals;


        public TestPage()
        {

            _listGoals = GoalsDB.GetInstance();

            // Start reviewing weekly goal's.
            _goalsPreviewList = new GoalsPreviewVM();
            _goalsPreviewList.Todos = GoalsDB.GetYearList();
            _goalsPreviewList.Intro = "Year Goals";
            _goalsPreviewList.Summary = "There is " + _goalsPreviewList.Todos.Count + " Goals this year of " + DateTime.Now.Year;
            BindingContext = _goalsPreviewList;



            InitializeComponent();

            //goalsListView.ItemsSource = _goalsPreviewList.Todos;    
            //goalsListView.ItemTemplate = new DataTemplate(typeof(TextCell));
            //goalsListView.ItemTemplate.SetBinding(TextCell.TextProperty, "Title");
            //goalsListView.ItemTemplate.SetBinding(TextCell.DetailProperty, "Text");
        }

        void OnMore(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;    
            DisplayAlert("More Context Action", item.CommandParameter + " more context action", "OK");
        }

        void OnDelete(object sender, EventArgs e)
        {
            var item = (MenuItem)sender;
            //items.Remove(item.CommandParameter.ToString());
        }
    }
}
