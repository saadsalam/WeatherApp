using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Interfaces;
using Xamarin.Forms;

namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {

        IWeatherService _weatherService;
        private static string apikey = "e63ae9a5453e4cec0d82c6c75131139e";


        public MainPage()
        {
            InitializeComponent();
            _weatherService = RestService.For<IWeatherService>("http://api.openweathermap.org");
        }

        protected async void GetWeather(object sender, EventArgs args)
        {
            var search = (SearchBar)sender;

            if (!string.IsNullOrEmpty(search.Text))
            {
                BindingContext = await _weatherService.GetTemp(search.Text, apikey);
            }

        }




    }
}
