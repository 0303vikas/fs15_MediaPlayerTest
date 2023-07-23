using Domain.src.Core;
using Domain.src.RepositoryInterface;

namespace Infrastructure.src.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<PlayList> _playList;

        public UserRepository()
        {
            _playList = new();
        }

        public void AddNewList(string name, int userId)
        {
            PlayList newList = new PlayList(name, userId);
            _playList.Add(newList);
            Console.WriteLine("New List added.");
        }

        public void EmptyOneList(int listId, int userId)
        {
            PlayList find = GetListById(listId);
            find.EmptyList(userId);
        }

        public IEnumerable<PlayList> GetAllList(int userId)
        {
            return _playList;
        }

        public PlayList GetListById(int listId)
        {
            PlayList? find = _playList.FirstOrDefault(item => item.GetId == listId);
            if (find != null) return find;
            else throw new Exception("No List matching with the provided listId was found.");
        }

        public void RemoveAllLists(int userId)
        {
            _playList.Clear();
            Console.WriteLine("List Cleared");
        }

        public void RemoveOneList(int listId, int userId)
        {
            int findIndex = _playList.FindIndex(item => item.GetId == listId);
            if (findIndex == -1) throw new Exception("No List matching the listId was found.");
            else _playList.RemoveAt(findIndex);
            Console.WriteLine("PlayList removed successfully");
        }

    }
}