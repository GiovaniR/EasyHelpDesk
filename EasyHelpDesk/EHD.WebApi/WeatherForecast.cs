using System;

namespace EHD.WebApi
{
    /// <summary>To DELETE</summary>
    public class WeatherForecast
    {
        /// <summary>To DELETE</summary>
        public DateTime Date { get; set; }
        /// <summary>To DELETE</summary>
        public int TemperatureC { get; set; }
        /// <summary>To DELETE</summary>
        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
        /// <summary>To DELETE</summary>
        public string Summary { get; set; }
    }
}
