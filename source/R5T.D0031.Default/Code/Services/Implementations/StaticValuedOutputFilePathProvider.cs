using System;
using System.Threading.Tasks;


namespace R5T.D0031.Default
{
    public class StaticValuedOutputFilePathProvider : IOutputFilePathProvider
    {
        public static string OutputFilePath { get; set; }


        public Task<string> GetOutputFilePath()
        {
            return Task.FromResult(StaticValuedOutputFilePathProvider.OutputFilePath);
        }
    }
}
