using System;
using System.Threading.Tasks;


namespace R5T.D0031
{
    public interface IOutputFilePathProvider
    {
        Task<string> GetOutputFilePathAsync();
    }
}
