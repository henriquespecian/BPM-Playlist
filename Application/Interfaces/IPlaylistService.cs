using BPMPlaylist.Application.Services;

namespace BPMPlaylist.Application.Interfaces
{
    public interface IPlaylistService 
    {
        Task<string> CreatePlaylist();
    }
}
