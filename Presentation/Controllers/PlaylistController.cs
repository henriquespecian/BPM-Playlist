using BPMPlaylist.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BPMPlaylist.Presentation.Controllers
{
    [ApiController]
    [Route("playlist")]
    public class PlaylistController : ControllerBase
    {
        private readonly IPlaylistService _playlistService;

        public PlaylistController(IPlaylistService playlistService)
        {
            _playlistService = playlistService;
        }

        /// <summary>
        /// Create a playlist based on tempo
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreatePlaylist(int tempo)
        {
            var name =  await _playlistService.CreatePlaylist();

            return Ok(name);
        }
    }
}
