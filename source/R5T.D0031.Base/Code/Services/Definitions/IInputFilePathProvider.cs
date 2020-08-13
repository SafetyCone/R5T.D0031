using System;
using System.Threading.Tasks;


namespace R5T.D0031
{
    public interface IInputFilePathProvider
    {
        Task<string> GetInputFilePath();
    }
}
