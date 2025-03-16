using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLibrary.Models
{
    public class Current
    {
        public int dt { get; set; } = 0;
        public int sunrise { get; set; } = 0;
        public int sunset { get; set; } = 0;
        public double temp { get; set; } = 0;
        public double feels_like { get; set; } = 0;
        public int pressure { get; set; } = 0;
        public int humidity { get; set; } = 0;
        public double dew_point { get; set; } = 0;
        public int uvi { get; set; } = 0;
        public int clouds { get; set; } = 0;
        public int visibility { get; set; } = 0;
        public double wind_speed { get; set; } = 0;
        public int wind_deg { get; set; } = 0;
        public double wind_gust { get; set; } = 0;
        public List<Weather> weather { get; set; } = null!;
    }

    public class Daily
    {
        public int dt { get; set; } = 0;
        public int sunrise { get; set; } = 0;
        public int sunset { get; set; } = 0;
        public int moonrise { get; set; } = 0;
        public int moonset { get; set; } = 0;
        public double moon_phase { get; set; } = 0;
        public string summary { get; set; } = "";
        public Temp temp { get; set; } = null!;
        public FeelsLike feels_like { get; set; } = null!;
        public int pressure { get; set; } = 0;
        public int humidity { get; set; } = 0;
        public double dew_point { get; set; } = 0;
        public double wind_speed { get; set; } = 0;
        public int wind_deg { get; set; } = 0;
        public double wind_gust { get; set; } = 0;
        public List<Weather> weather { get; set; } = null!;
        public int clouds { get; set; } = 0;
        public double pop { get; set; } = 0;
        public double rain { get; set; } = 0;
        public double uvi { get; set; } = 0;
    }

    public class FeelsLike
    {
        public double day { get; set; } = 0;
        public double night { get; set; } = 0;
        public double eve { get; set; } = 0;
        public double morn { get; set; } = 0;
    }

    public class Hourly
    {
        public int dt { get; set; } = 0;
        public double temp { get; set; } = 0;
        public double feels_like { get; set; } = 0;
        public int pressure { get; set; } = 0;
        public int humidity { get; set; } = 0;
        public double dew_point { get; set; } = 0;
        public double uvi { get; set; } = 0;
        public int clouds { get; set; } = 0;
        public int visibility { get; set; } = 0;
        public double wind_speed { get; set; } = 0;
        public int wind_deg { get; set; } = 0;
        public double wind_gust { get; set; } = 0;
        public List<Weather> weather { get; set; } = null!;
        public double pop { get; set; } = 0;
        //public Rain rain { get; set; }
    }

    public class Minutely
    {
        public int dt { get; set; } = 0;
        public int precipitation { get; set; } = 0;
    }

    //public class Rain
    //{
    //    [JsonProperty("1h")]
    //    public double _1h { get; set; }
    //}

    public class OpenWeatherResponse
    {
        public double lat { get; set; } = 0;
        public double lon { get; set; } = 0;
        public string timezone { get; set; } = "";
        public int timezone_offset { get; set; } = 0;
        public Current current { get; set; } = null!;
        public List<Minutely> minutely { get; set; } = null!;
        public List<Hourly> hourly { get; set; } = null!;
        public List<Daily> daily { get; set; } = null!;
    }

    public class Temp
    {
        public double day { get; set; } = 0;
        public double min { get; set; } = 0;
        public double max { get; set; } = 0;
        public double night { get; set; } = 0;
        public double eve { get; set; } = 0;
        public double morn { get; set; } = 0;
    }

    public class Weather
    {
        public int id { get; set; } = 0;
        public string main { get; set; } = "";
        public string description { get; set; } = "";
        public string icon { get; set; } = "";
    }
}