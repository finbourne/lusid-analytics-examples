using Lusid.Sdk.Extensions;

namespace Lusid.Instruments.Examples.Utilities
{
    public class TestLusidApiFactoryBuilder
    {
        public static IApiFactory CreateApiFactory(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiFactoryBuilder.Build(secretsFile)
                : ApiFactoryBuilder.BuildFromEnvironmentVariables();
        }

        public static ApiConfiguration CreateApiConfiguration(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiConfigurationBuilder.Build(secretsFile)
                : ApiConfigurationBuilder.BuildFromEnvironmentVariables();
        }
    }
}