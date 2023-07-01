using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.src.Core;

namespace Domain.src.RepositoryInterface
{
    public interface IPlayListRepository
    {
        void AddNewFile(int playListId, int fileId, int userId);
        void RemoveFile(int playListId, int fileId, int userId);
        void EmptyList(int playListId, int userId);
    }
}