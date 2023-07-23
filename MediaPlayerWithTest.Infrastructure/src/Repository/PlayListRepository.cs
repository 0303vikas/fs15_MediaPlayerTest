using Domain.src.Core;
using Domain.src.RepositoryInterface;

namespace Infrastructure.src.Repository
{
    public class PlayListRepository : IPlayListRepository
    {
        private List<MediaFile> _mediaFile;
        private List<MediaFile> _mediaList;

        public PlayListRepository()
        {
            _mediaFile = new List<MediaFile>();
        }

        public void AddNewFile(int playListId, int fileId, int userId, double speed)
        {
            MediaFile create = new Video(playListId, fileId, userId, speed);
        }

        public void EmptyList(int playListId, int userId)
        {
            _mediaFile.Clear();
        }

        public void RemoveFile(int playListId, int fileId, int userId)
        {
            int findIndex = _mediaFile.FindIndex(item => item.GetId == fileId);
            if (findIndex == -1) throw new Exception("No File with the provided id was found.");
            else _mediaFile.RemoveAt(findIndex);
            Console.WriteLine("File removed Successfully.");
        }
    }
}