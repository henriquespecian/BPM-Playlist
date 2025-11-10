using BPMPlaylist.Application.Interfaces;
using BPMPlaylist.Application.Services;

namespace BPMPlaylist.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {

            services.AddScoped<IPlaylistService, PlaylistService>();

            return services;
        }
    }
}
