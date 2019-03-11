using VSTestIssueProject;

namespace VSTestIssue
{
    public class Config : IConfig
    {
        public ConfigService ConfigService { get; set; }
        public LogLevel LogLevel { get; set; }
        public int CheckInterval { get; set; }

        public Config()
        {
        }
    }
}
