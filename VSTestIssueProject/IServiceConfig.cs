using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VSTestIssueProject
{
    public interface IConfig
    {
        [JsonProperty("configService")]
        ConfigService ConfigService { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("logLevel")]
        LogLevel LogLevel { get; }

        [JsonProperty("checkInterval")]
        int CheckInterval { get; }
    }
}
