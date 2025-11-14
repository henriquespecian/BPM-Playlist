using BPMPlaylist.Application.Interfaces;
using SpotifyAPI.Web;

namespace BPMPlaylist.Application.Services
{
    public class SpotifyPlaylistService : IPlaylistService
    {
        public async Task<string> CreatePlaylist()
        {
            var spotify = new SpotifyClient("");

            var track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            Console.WriteLine(track.Name);

            return track.Name;
        }
    }
}