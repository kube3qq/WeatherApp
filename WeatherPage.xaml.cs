using System.Runtime.CompilerServices;
using WeatherApp1.Services;

namespace WeatherApp1;

public partial class WeatherPage : ContentPage
{
    public List<Models.List> WeatherList;
    private double latitude;
    private double longitude;
    public WeatherPage()
    {
        InitializeComponent();
        WeatherList = new List<Models.List>();

    }

    protected async override void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation();
        await GetWeatherByLocation(latitude, longitude);

    }

    public async Task GetLocation()
    {
        var location = await Geolocation.GetLocationAsync();
        latitude = location.Latitude;
        longitude = location.Longitude;
    }

    private async void TapLocation_Tapped(object sender, EventArgs e)
    {
        await GetLocation();
        await GetWeatherByLocation(latitude, longitude);
    }

    public async Task GetWeatherByLocation(double latitude, double longitude)
    {
        var result = await ApiServices.GetWeather(latitude, longitude);
        UpdateUI(result);
    }

    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        var response = await DisplayPromptAsync(title: "", message: "", placeholder: "Search weather by city", accept: "Search", cancel: "Cancel");
        if (response != null) 
        {
            await GetWeatherByCity(response);
        }
    }

    public async Task GetWeatherByCity(string city)
    {
        var result = await ApiServices.GetWeatherByCity(city);
        UpdateUI(result);
    }

    public void UpdateUI(dynamic result) 
    {
        foreach (var item in result.list)
        {
            WeatherList.Add(item);
        }
        CvWeather.ItemsSource = WeatherList;
        City.Text = result.city.name;
        WeatherDesc.Text = result.list[0].weather[0].description;
        Temperature.Text = result.list[0].main.temperature + "°C";
        Humidity.Text = result.list[0].main.humidity + "%";
        Wind.Text = result.list[0].wind.speed + "km/h";
        ImgWeatherIcon.Source = result.list[0].weather[0].fullIconUrl;
    }
}