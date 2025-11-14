using BPMPlaylist.Application.Interfaces;
using SpotifyAPI.Web;

namespace BPMPlaylist.Application.Services
{
    public class AuthenticationService : IAuthenticatorService
    {
        public string Authenticate()
        {
            var loginRequest = new LoginRequest(
                new Uri("https://localhost:8080/auth/callback"),
                "ba8c60389dff4c919a34b440c91c9023",
                LoginRequest.ResponseType.Token
            )
            {
                Scope = new[] { Scopes.PlaylistReadPrivate, Scopes.PlaylistReadCollaborative }
            };

            var a = loginRequest.ToUri();

            return a.AbsoluteUri;
        }

        public async Task Callback(string? code)
        {
            var response = await new OAuthClient().RequestToken(
              new AuthorizationCodeTokenRequest("ClientId", "ClientSecret", code, new Uri("http://localhost:5543"))
            );

            var config = SpotifyClientConfig
              .CreateDefault()
              .WithAuthenticator(new AuthorizationCodeAuthenticator("ClientId", "ClientSecret", response));

            var spotify = new SpotifyClient(config);
        }
    }
}
