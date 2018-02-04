using System;
using System.Collections.Generic;
using TODO.Data;
using TODO.Models;
using Xamarin.Forms;

namespace TODO.Views
{
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {
            InitializeComponent();
            this.Title = "Today's Weather";
            getWeatherBtn.Clicked += GetWeather;

            //Set the default binding to a default object for now
            this.BindingContext = new Weather();


        }

        async void GetWeather(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(cityIdEntry.Text))
            {
                Weather weather = await WeatherApi.GetWeather(cityIdEntry.Text);
                if (weather != null)
                {
                    this.BindingContext = weather;
                    getWeatherBtn.Text = "Search Again";
                }
            }
        }
    }
}
