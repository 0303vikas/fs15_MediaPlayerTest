using Business.src.ServiceInterface;

namespace Application.src
{
    public class MediaController
    {
        private readonly IMediaService _mediaService;

        public MediaController(IMediaService mediaService)
        {
            _mediaService = mediaService;
        }

        public void CreateNewFile(string fileName, string filePath, TimeSpan duration, double speed)
        {
            _mediaService.CreateNewFile(fileName, filePath, duration, speed);
        }

        public void DeleteFileById(int id)
        {
            _mediaService.DeleteFileById(id);
        }

        public void GetAllFiles()
        {
            _mediaService.GetAllFiles();
        }

        public void GetFileById(int id)
        {
            _mediaService.GetFileById(id);
        }
    }
}