using Newtonsoft.Json;

namespace VSTestIssueProject
{
    public class ConfigService
    {
        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("group")]
        public string Group { get; set; }

        [JsonProperty("updateInterval")]
        public int UpdateInterval { get; set; }

        public ConfigService()
        {
        }
    }
}
