namespace Business.src.ServiceInterface
{
    public interface IMediaService
    {
        void CreateNewFile(string fileName, string filePath, TimeSpan duration, double speed);
        void DeleteFileById(int id);
        void GetAllFiles();
        void GetFileById(int id);
    }
}