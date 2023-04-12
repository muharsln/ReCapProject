using Microsoft.AspNetCore.Http;

namespace Core.Utilities.Helper.FileTool
{
    public interface IFileHelper
    {
        string Upload(IFormFile file, string root);
        string Update(IFormFile file, string filePath, string root);
        void Delete(string filePath);
    }
}
