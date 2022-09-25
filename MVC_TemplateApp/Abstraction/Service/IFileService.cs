namespace MVC_TemplateApp.Abstraction.Service
{
    public interface IFileService
    {
        Task<string> UploadFile(IFormFile file, string fileType, int fileSize);
        Task<bool> DeleteFile(string filePath);
        Task<bool> FileValidation(IFormFile file, string FileType, int fileSize);
    }
}
