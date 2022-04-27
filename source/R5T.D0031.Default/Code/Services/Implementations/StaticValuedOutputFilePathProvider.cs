using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0031.Default
{[ServiceImplementationMarker]
    public class StaticValuedOutputFilePathProvider : IOutputFilePathProvider,IServiceImplementation
    {
        public static string OutputFilePath { get; set; }


        public Task<string> GetOutputFilePath()
        {
            return Task.FromResult(StaticValuedOutputFilePathProvider.OutputFilePath);
        }
    }
}
