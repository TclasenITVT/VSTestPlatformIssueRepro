using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VSTestIssue
{
    public class SimpleTestClass
    {
        public string Name { get; set; }

        public int Number { get; set; }

        public bool Bool { get; set; }

        public Test Test { get; set; }
    }

    public class Test
    {
        public string TestName { get; set; }

        public int TestNumber { get; set; }

        public bool TestBool { get; set; }
    }
}
