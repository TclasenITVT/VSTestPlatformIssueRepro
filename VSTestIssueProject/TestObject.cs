using Newtonsoft.Json;

namespace VSTestIssueProject
{
    public class TestObject
    {
        [JsonProperty("test")]
        public string Test { get; set; }

        [JsonProperty("intTest")]
        public int IntTest { get; set; }

        public TestObject()
        {
        }
    }
}
