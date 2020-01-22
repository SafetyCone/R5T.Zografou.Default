using System;


namespace R5T.Zografou.Default
{
    public class TestingDataDirectoryNameConvention : ITestingDataDirectoryNameConvention
    {
        public const string TestingDataDirectoryName = "Testing Data";


        public string GetTestingDataDirectoryName()
        {
            return TestingDataDirectoryNameConvention.TestingDataDirectoryName;
        }
    }
}
