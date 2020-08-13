using System;
using System.Threading.Tasks;


namespace R5T.D0031.Default
{
    public class StaticValuedInputFilePathProvider : IInputFilePathProvider
    {
        public static string InputFilePath { get; set; }


        public Task<string> GetInputFilePath()
        {
            return Task.FromResult(StaticValuedInputFilePathProvider.InputFilePath);
        }
    }
}
