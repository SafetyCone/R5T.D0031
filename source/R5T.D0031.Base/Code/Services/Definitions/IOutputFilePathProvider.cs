using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0031
{
    [ServiceDefinitionMarker]
    public interface IOutputFilePathProvider : IServiceDefinition
    {
        Task<string> GetOutputFilePath();
    }
}
