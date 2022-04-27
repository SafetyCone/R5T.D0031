using System;
using System.Threading.Tasks;using R5T.T0064;


namespace R5T.D0031.Default
{[ServiceImplementationMarker]
    public class StaticValuedInputFilePathProvider : IInputFilePathProvider,IServiceImplementation
    {
        public static string InputFilePath { get; set; }


        public Task<string> GetInputFilePath()
        {
            return Task.FromResult(StaticValuedInputFilePathProvider.InputFilePath);
        }
    }
}
