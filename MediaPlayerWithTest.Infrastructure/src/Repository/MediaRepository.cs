using Domain.src.Core;
using Domain.src.RepositoryInterface;

namespace Infrastructure.src.Repository
{
    public class MediaRepository : IMediaRepository
    {
        private List<MediaFile> _mediaCollection;
        // private static MediaRepository _instance;
        // private static readonly Object _lock = new Object();

        // public MediaRepository Instance
        // {
        //     get
        //     {
        //         if (_instance == null)
        //         {
        //             lock (_lock)
        //             {
        //                 _instance = new MediaRepository();
        //             }
        //         }
        //         return _instance;
        //     }
        // }

        public MediaRepository()
        {
            _mediaCollection = new List<MediaFile>();
        }

        public void CreateNewFile(string fileName, string filePath, TimeSpan duration, double speed)
        {
            MediaFile media = new Video(fileName, filePath, duration, speed);
            _mediaCollection.Add(media);
        }

        public void DeleteFileById(int fileId)
        {
            MediaFile find = GetFileById(fileId);
            _mediaCollection.Remove(find);
            Console.WriteLine("Media removed successfully.");
        }

        public IEnumerable<MediaFile> GetAllFiles()
        {
            return _mediaCollection;
        }

        public MediaFile GetFileById(int fileId)
        {
            MediaFile? FindMedia = _mediaCollection.Find(item => item.GetId == fileId);
            if (FindMedia == null) throw new Exception("No Media With given id exist.");
            else return FindMedia;
        }

        public void Pause(int fileId)
        {
            MediaFile find = GetFileById(fileId);
            find.Pause();
        }

        public void Play(int fileId)
        {
            MediaFile find = GetFileById(fileId);
            find.Play();
        }

        public void Stop(int fileId)
        {
            MediaFile find = GetFileById(fileId);
            find.Stop();
        }
    }
}