namespace BPMPlaylist.Application.Interfaces
{
    public interface IAuthenticatorService
    {
        string Authenticate();

        Task Callback(string code);
    }
}
