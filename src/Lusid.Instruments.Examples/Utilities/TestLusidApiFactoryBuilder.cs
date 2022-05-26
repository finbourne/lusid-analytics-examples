using Lusid.Sdk.Utilities;

namespace Lusid.Instruments.Examples.Utilities
{
    public class TestLusidApiFactoryBuilder
    {
        public static ILusidApiFactory CreateApiFactory(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? LusidApiFactoryBuilder.Build(secretsFile)
                : LusidApiFactoryBuilder.Build(null);
        }
        
        public static ApiConfiguration CreateApiConfiguration(string secretsFile)
        {
            return File.Exists(secretsFile)
                ? ApiConfigurationBuilder.Build(secretsFile)
                : ApiConfigurationBuilder.Build(null);
        }
    }
}