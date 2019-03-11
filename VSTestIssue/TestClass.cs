using Newtonsoft.Json;
using VSTestIssueProject;
using Xunit;

namespace VSTestIssue
{
    public class TestClass
    {
        [Fact]
        public void Test()
        {
            Config config = new Config
            {
                LogLevel = LogLevel.Info,
                CheckInterval = 5,
                ConfigService = new ConfigService
                {
                    Group = "Mock",
                    Token = "Mock",
                    UpdateInterval = 5,
                    Url = "Mock"
                }
            };

            string json = JsonConvert.SerializeObject(config);
            Assert.Contains(@"Info", json);
        }

        [Fact]
        public void TestSimpleObject()
        {
            var testObject = new SimpleTestClass()
            {
                Bool = true,
                Name = "Max Mustermann",
                Number = 12356123,
                Test = new Test()
                {
                    TestBool = false,
                    TestName = "Harry Potter",
                    TestNumber = 81234634
                }
            };
            string json = JsonConvert.SerializeObject(testObject);
            Assert.Contains("Max", json);
        }
    }
}
