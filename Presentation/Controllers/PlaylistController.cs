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

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> CreatePlaylist(int tempo)
        {
            var name =  await _playlistService.CreatePlaylist();

            return Ok(name);
        }
    }
}
