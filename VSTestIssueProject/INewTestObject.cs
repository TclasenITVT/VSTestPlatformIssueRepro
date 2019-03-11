using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace VSTestIssueProject
{
    public interface INewTestObject
    {
        [JsonProperty("test")]
        TestObject TestObject { get; }

        [JsonProperty("something")]
        string Something { get; }

        [JsonConverter(typeof(StringEnumConverter))]
        [JsonProperty("logLevel")]
        LogLevel LogLevel { get; }
    }
}
