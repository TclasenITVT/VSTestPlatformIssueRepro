using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSTestIssueProject;

namespace VSTestIssue
{
    public class NewTestObject : INewTestObject
    {
        public TestObject TestObject { get; set; }

        public string Something { get; set; }

        public LogLevel LogLevel { get; set; }

        public NewTestObject()
        {
        }
    }
}
