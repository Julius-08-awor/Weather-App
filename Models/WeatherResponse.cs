using System.Text.Json.Serialization;

namespace WeatherApp.Models;

public class WeatherResponse
{
    [JsonPropertyName("name")]
    public string City { get; set; } = "";

    [JsonPropertyName("sys")]
    public Sys Sys { get; set; } = new();

    [JsonPropertyName("main")]
    public Main Main { get; set; } = new();

    [JsonPropertyName("weather")]
    public List<WeatherInfo> Weather { get; set; } = new();

    [JsonPropertyName("wind")]
    public Wind Wind { get; set; } = new();

    [JsonPropertyName("visibility")]
    public int Visibility { get; set; }

    [JsonPropertyName("timezone")]
    public int Timezone { get; set; }
}

public class Sys
{
    [JsonPropertyName("country")]
    public string Country { get; set; } = "";

    [JsonPropertyName("sunrise")]
    public long Sunrise { get; set; }

    [JsonPropertyName("sunset")]
    public long Sunset { get; set; }
}

public class Main
{
    [JsonPropertyName("temp")]
    public double Temp { get; set; }

    [JsonPropertyName("feels_like")]
    public double FeelsLike { get; set; }

    [JsonPropertyName("humidity")]
    public int Humidity { get; set; }

    [JsonPropertyName("pressure")]
    public int Pressure { get; set; }

    [JsonPropertyName("temp_min")]
    public double TempMin { get; set; }

    [JsonPropertyName("temp_max")]
    public double TempMax { get; set; }
}

public class WeatherInfo
{
    [JsonPropertyName("main")]
    public string Main { get; set; } = "";

    [JsonPropertyName("description")]
    public string Description { get; set; } = "";

    [JsonPropertyName("icon")]
    public string Icon { get; set; } = "";
}

public class Wind
{
    [JsonPropertyName("speed")]
    public double Speed { get; set; }
}

public class ForecastResponse
{
    [JsonPropertyName("list")]
    public List<ForecastItem> List { get; set; } = new();
}

public class ForecastItem
{
    [JsonPropertyName("dt_txt")]
    public string DateText { get; set; } = "";

    [JsonPropertyName("main")]
    public Main Main { get; set; } = new();

    [JsonPropertyName("weather")]
    public List<WeatherInfo> Weather { get; set; } = new();
}

public class UvResponse
{
    [JsonPropertyName("value")]
    public double Value { get; set; }
}