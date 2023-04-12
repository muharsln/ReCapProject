using Microsoft.AspNetCore.Http;
using Core.Utilities.Helper.GuidTool;

namespace Core.Utilities.Helper.FileTool
{
    public class FileHelper : IFileHelper
    {
        public void Delete(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
        }

        public string Update(IFormFile file, string filePath, string root)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            return Upload(file, root);
        }

        public string Upload(IFormFile file, string root)
        {
            if (file.Length > 0 || file != null)
            {
                if (!Directory.Exists(root))
                {
                    Directory.CreateDirectory(root);
                }
            }

            string extension = Path.GetExtension(file.FileName);
            string guid = GuidHelper.GetUniqName();
            string filePath = guid + extension;

            using (FileStream fileStream = File.Create(root + filePath))
            {
                file.CopyTo(fileStream);
                fileStream.Flush();
                return filePath;
            }
            return null;
        }
    }
}
