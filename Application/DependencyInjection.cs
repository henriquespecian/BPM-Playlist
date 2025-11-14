using BPMPlaylist.Application.Interfaces;
using BPMPlaylist.Application.Services;
using SpotifyAPI.Web;
using static SpotifyAPI.Web.Scopes;

namespace BPMPlaylist.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IPlaylistService, SpotifyPlaylistService>();
            services.AddScoped<IAuthenticatorService, AuthenticationService>();
            

            return services;
        }
    }
}
