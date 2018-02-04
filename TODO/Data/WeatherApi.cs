using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Xml.Serialization;
using System.Threading.Tasks;
using System.Collections.Generic;
using TODO.Models;
using Newtonsoft.Json.Linq;

namespace TODO.Data
{
    public class WeatherApi
    {
        public WeatherApi()
        {
        }


        public static async Task<Weather> GetWeather(string cityId)
        {
            string key = "f297e62930c74545de47bd8ca937b5a6";
            string queryString = "http://api.openweathermap.org/data/2.5/weather?id="
                + cityId + "&appid=" + key + "&units=metric";

            var results = await getDataFromService(queryString).ConfigureAwait(false);

            if (results["weather"] != null)
            {
                Weather weather = new Weather();
                weather.Title = (string)results["name"];
                weather.Temperature = (string)results["main"]["temp"] + " F";
                weather.Wind = (string)results["wind"]["speed"] + " mph";
                weather.Humidity = (string)results["main"]["humidity"] + " %";
                weather.Visibility = (string)results["weather"][0]["main"];

                DateTime time = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
                DateTime sunrise = time.AddSeconds((double)results["sys"]["sunrise"]);
                DateTime sunset = time.AddSeconds((double)results["sys"]["sunset"]);
                weather.Sunrise = sunrise.ToString() + " UTC";
                weather.Sunset = sunset.ToString() + " UTC";
                return weather;
            }
            else
            {
                return null;
            }
        }

        public static async Task<JContainer> getDataFromService(string queryString)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(queryString);

            JContainer data = null;
            if (response != null)
            {
                string json = response.Content.ReadAsStringAsync().Result;
                data = (JContainer)JsonConvert.DeserializeObject(json);
            }

            return data;
        }
    }
}
