using BPMPlaylist.Application.Interfaces;
using SpotifyAPI.Web;

namespace BPMPlaylist.Application.Services
{
    public class PlaylistService : IPlaylistService
    {
        public async Task<string> CreatePlaylist()
        {
            var spotify = new SpotifyClient("BQB5WHZKUajgzTpwTF0C52IxW0byG89nX3peIw6lbgjzQ1v_LwnkR1kQS1126vqXF-gBOumGdMJqYS4kcSX0U5Yfzk1NRhvU6R3uaR2YredqsR3aNfzdcUOS0PusUewIPInLYY5gPtP-uG_4qA4jKUnjqyynWjk7gBtB9eqWiwxrJjHs6VkBk90wlzC-RDLnNWWL2sfeJ6y9nZFaPR6IgFsJ0yIbUk_NuVhS46eqhi6J3ib-Z-IvPflb-wH_hEL_gazBPQS7k5VugyTlGp4e44YRYWZa-xZAYiHmCkDYZAFezUQFvaav7pg4-_g2wPwaj3b5_o10M2otf70e0slPGXR0m-nEXZvOeYD-ydThK9UTVB3IUdEU9_Yt2y2ImGbM__BIi-8m");

            var track = await spotify.Tracks.Get("1s6ux0lNiTziSrd7iUAADH");
            Console.WriteLine(track.Name);

            return track.Name;
        }
    }
}