using System;
using Xunit;
using FluentAssertions;
using ADConnectionTest; 

namespace ConnectionStringTests
{
    public class UnitTest1
    {
        [Theory]
        //[InlineData("Data Source=.;Initial Catalog=master;User ID=sa;Password=P@ssw0rd;MultipleActiveResultSets=True;")]
        //[InlineData("Data Source=.;Integrated Security=True")]
        [MemberData(nameof(TestInfo.GetStrings), MemberType=typeof(TestInfo))]
        public void CanConnect(string cstr)
        {
            Connect.connectionString = cstr ;
            var x = new Connect();
        }
    }
}
