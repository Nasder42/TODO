using System;

using Xamarin.Forms;

namespace TODO
{
    public class App : Application
    {
        public App()
        {
            Button button = new Button
            {
                Text = "Test me!"
            };

            button.Clicked += async (sender, e) => {
                await MainPage.DisplayAlert("Alert", "You Clicked me!", "Okay");
            };

            // The root page of your application
            var content = new ContentPage
            {
                Title = "TODO",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        new Label {
                            HorizontalTextAlignment = TextAlignment.Center,
                            Text = "Welcome to Xamarin Forms!"
                        },
                        button


                    }
                }
            };


            MainPage = new NavigationPage(content);




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
