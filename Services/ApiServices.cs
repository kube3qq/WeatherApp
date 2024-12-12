using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp1.Models;

namespace WeatherApp1.Services
{
    public static class ApiServices
    {
        public static async Task<Root> GetWeather(double latitude, double longitude)
        {
            var httpClient = new HttpClient();
            var res = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&units=metric&appid=244a9f9377eb8f8e9999d9a4e88f5e98", latitude, longitude));
            return JsonConvert.DeserializeObject<Root>(res);
        }

        public static async Task<Root> GetWeatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var res = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q={0}&units=metric&appid=244a9f9377eb8f8e9999d9a4e88f5e98", city));
            return JsonConvert.DeserializeObject<Root>(res);
        }
    }

}
