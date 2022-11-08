namespace WebApplication11
{
    public interface IWeatherforecastServices
    {
        IEnumerable<WeatherForecast> Get();
        IEnumerable<WeatherForecast> Get(int liczbarezultatow, int mintemp, int maxtemp);
    }
}