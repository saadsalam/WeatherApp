using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.Models;
using Refit;



namespace WeatherApp.Interfaces
{
   public interface IWeatherService
    {

        [Get("/data/2.5/weather?zip={zipcode}&appid={appid}&units=imperial")]
        Task<WeatherModel> GetTemp(string zipcode, string appid);
    }
}
