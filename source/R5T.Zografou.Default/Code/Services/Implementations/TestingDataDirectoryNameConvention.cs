using System;using R5T.T0064;


namespace R5T.Zografou.Default
{[ServiceImplementationMarker]
    public class TestingDataDirectoryNameConvention : ITestingDataDirectoryNameConvention,IServiceImplementation
    {
        public const string TestingDataDirectoryName = "Testing Data";


        public string GetTestingDataDirectoryName()
        {
            return TestingDataDirectoryNameConvention.TestingDataDirectoryName;
        }
    }
}
