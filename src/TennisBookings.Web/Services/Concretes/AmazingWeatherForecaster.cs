using TennisBookings.Web.Services.Interfaces;

namespace TennisBookings.Web.Services.Concretes
{
    public class AmazingWeatherForecaster : IWeatherForecaster
    {
        public WeatherResult GetCurrentWeather()
        {
            // DO SOMETHING AMAZING HERE!!!

            return new WeatherResult
            {
                WeatherCondition = WeatherCondition.Sun
            };
        }
    }
}
