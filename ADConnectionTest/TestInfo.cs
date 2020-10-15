using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ADConnectionTest
{
    public class TestInfo
    {
        private static string connectionsFile =  Environment.GetEnvironmentVariable("connectionsFile")
                   ?? Environment.GetEnvironmentVariable("connectionsFile", EnvironmentVariableTarget.User)
                   ?? Environment.GetEnvironmentVariable("connectionsFile", EnvironmentVariableTarget.Process)
                   ?? Environment.GetEnvironmentVariable("connectionsFile", EnvironmentVariableTarget.Machine);
        public static IEnumerable<object[]> GetStrings()
        {
            return File.ReadAllLines(connectionsFile).Select(x => new object[] { x }); 
        }
    }
}
